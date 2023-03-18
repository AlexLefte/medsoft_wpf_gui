using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using MedSoftDashboard.MVVM.Commands;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Commands.ClientCommands;
using System.Collections;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class AddClientViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        #region Fields

        private int _id;
        private string _nume;
        private string _numeRepr;
        private string _prenumeRepr;
        private string _tara;
        private string _regiune;
        private string _oras;
        private string _adresa;
        private string _telefon;

        private Workspace _workspace;

        #endregion


        #region Properties

        public int Id { get { return _id; } }

        public string Nume
        {
            get { return _nume; }
            set
            {
                _nume = value;
                OnPropertyChanged(nameof(Nume));

                ClearErrors(nameof(Nume));

                if (Nume == null || Nume == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Nume));                   
                }
                else if (_workspace.ClientsList.Any(client => client.Nume.ToLower() == Nume.ToLower()))
                {
                    AddError("Nume deja existent.", nameof(Nume));
                }
            }
        }
        public string NumeReprezentant
        {
            get { return _numeRepr; }
            set
            {
                _numeRepr = value;
                OnPropertyChanged(nameof(NumeReprezentant));

                ClearErrors(nameof(NumeReprezentant));

                if (NumeReprezentant == null || NumeReprezentant == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(NumeReprezentant));
                }
            }
        }
        public string PrenumeReprezentant
        {
            get { return _prenumeRepr; }
            set
            {
                _prenumeRepr = value;
                OnPropertyChanged(nameof(PrenumeReprezentant));

                ClearErrors(nameof(PrenumeReprezentant));

                if (PrenumeReprezentant == null || PrenumeReprezentant == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(PrenumeReprezentant));
                }
            }
        }
        public string Tara
        {
            get { return _tara; }
            set
            {
                _tara = value;
                OnPropertyChanged(nameof(Tara));

                ClearErrors(nameof(Tara));

                if (Tara == null || Tara == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Tara));
                }
            }
        }
        public string Regiune
        {
            get { return _regiune; }
            set
            {
                _regiune = value;
                OnPropertyChanged(nameof(Regiune));

                ClearErrors(nameof(Regiune));

                if (Regiune == null || Regiune == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Regiune));
                }
            }
        }
        public string Oras
        {
            get { return _oras; }
            set
            {
                _oras = value;
                OnPropertyChanged(nameof(Oras));

                ClearErrors(nameof(Oras));

                if (Oras == null || Oras == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Oras));
                }
            }
        }
        public string Adresa
        {
            get { return _adresa; }
            set
            {
                _adresa = value;
                OnPropertyChanged(nameof(Adresa));

                ClearErrors(nameof(Adresa));

                if (Adresa == null || Adresa == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Adresa));
                }
            }
        }
        public string Telefon
        {
            get { return _telefon; }
            set
            {
                _telefon = value;
                OnPropertyChanged(nameof(Telefon));

                ClearErrors(nameof(Telefon));

                if (Telefon == null || Telefon == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Telefon));
                }
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        #endregion


        #region Errors

        private Dictionary<string, string> _propertyNameToErrorsDictionary;

        public Dictionary<string, string> PropertyNamesToErrors
        {
            get => _propertyNameToErrorsDictionary;
            set
            {
                _propertyNameToErrorsDictionary = value;
                OnPropertyChanged();
            }
        }

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
        public bool HasErrors => _propertyNameToErrorsDictionary.Any();

        private void ClearErrors(string property)
        {
            _propertyNameToErrorsDictionary.Remove(property);
            OnErrorsChanged(property);
        }

        private void OnErrorsChanged(string property)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(property));
            OnPropertyChanged(nameof(PropertyNamesToErrors));
        }

        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyNameToErrorsDictionary.GetValueOrDefault(propertyName, string.Empty);
        }

        private void AddError(string errorMessage, string property)
        {
            if (!_propertyNameToErrorsDictionary.ContainsKey(property))
            {
                _propertyNameToErrorsDictionary.Add(property, string.Empty);
            }

            _propertyNameToErrorsDictionary[property] = errorMessage;

            OnErrorsChanged(property);
        }

        #endregion


        #region Constructor

        public AddClientViewModel(Workspace workspace, NavigationService navServ)
        {
            _workspace = workspace;
            SubmitCommand = new AddClientCommand(this, workspace, navServ);
            CancelCommand = new NavigateCommand(navServ);

            _propertyNameToErrorsDictionary = new Dictionary<string, string>();
        }
        #endregion

        #region Methods

        public bool CheckCanExecute()
        {
            var result = (Nume != null) && (NumeReprezentant != null) && (PrenumeReprezentant != null)
                && (Tara != null) && (Regiune != null) && (Oras != null) && (Adresa != null) && (Telefon != null)
                && (Nume != string.Empty) && (NumeReprezentant != string.Empty) && (PrenumeReprezentant != string.Empty)
                && (Tara != string.Empty) && (Regiune != string.Empty) && (Oras != string.Empty) && (Adresa != string.Empty)
                && (Telefon != string.Empty) && !_propertyNameToErrorsDictionary.Any();
            return result;
        }

        #endregion
    }
}
