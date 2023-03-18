using MedSoftDashboard.MVVM.Commands;
using MedSoftDashboard.MVVM.Commands.ProjectCommands;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class AddProjectViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        #region Fields

        private string _id;
        private string _nume;
        private string _tip;
        private string _descriere;
        private DateTime _dataFinalizare;
        private DateTime _dataActualizare;
        private string _versiune;

        private Workspace _workspace;

        #endregion

        #region Properties

        public string Id { 
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));

                ClearErrors(nameof(Id));

                if (Id == null || Id == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Id));
                }
                else if (_workspace.ProjectsList.Any(project => project.Id.ToLower() == Id.ToLower()))
                {
                    AddError("Id deja existent.", nameof(Id));
                }
            }
        }

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
                else if (_workspace.ProjectsList.Any(project => project.Nume.ToLower() == Nume.ToLower()))
                {
                    AddError("Nume deja existent.", nameof(Nume));
                }
            }
        }
        public string Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                OnPropertyChanged(nameof(Tip));

                ClearErrors(nameof(Tip));

                if (Tip == null || Tip == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Tip));
                }
            }
        }
        public string Descriere
        {
            get { return _descriere; }
            set
            {
                _descriere = value;
                OnPropertyChanged(nameof(Descriere));

                ClearErrors(nameof(Descriere));

                if (Descriere == null || Descriere == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Descriere));
                }
            }
        }
        public DateTime DataFinalizare
        {
            get { return _dataFinalizare; }
            set
            {
                _dataFinalizare = value;
                OnPropertyChanged(nameof(DataFinalizare));

                ClearErrors(nameof(DataFinalizare));

                if ((DataActualizare != DateTime.MinValue) && (DateTime.Compare(DataFinalizare, DataActualizare) > 0))
                {
                    AddError("Data finalizare > Data actualizare.", nameof(DataFinalizare));
                }
            }
        }
        public DateTime DataActualizare
        {
            get { return _dataActualizare; }
            set
            {
                _dataActualizare = value;
                OnPropertyChanged(nameof(DataActualizare));

                ClearErrors(nameof(DataActualizare));
                
                if (DataFinalizare.Day > DataActualizare.Day)
                {
                    AddError("Data finalizare > Data actualizare.", nameof(DataActualizare));
                }
            }
        }
        public string Versiune
        {
            get { return _versiune; }
            set
            {
                _versiune = value;
                OnPropertyChanged(nameof(Versiune));

                ClearErrors(nameof(Versiune));

                if (Versiune == null || Versiune == string.Empty)
                {
                    AddError("Obligatoriu.", nameof(Versiune));
                }
            }
        }
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        #endregion


        #region Constructor

        public AddProjectViewModel(Workspace ws, NavigationService navServ)
        {
            _workspace = ws;

            SubmitCommand = new AddProjectCommand(this, ws, navServ);
            CancelCommand = new NavigateCommand(navServ);

            _propertyNameToErrorsDictionary = new Dictionary<string, string>();
            DataFinalizare = DateTime.Now;
            DataActualizare = DateTime.Now;
        }
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

        #region Methods

        public bool CheckCanExecute()
        {
            var result = (Id != null) && (Nume != null) && (Tip != null) && (Descriere != null) &&
                (DataActualizare != null) && (DataFinalizare != null) && (Versiune != null) && !_propertyNameToErrorsDictionary.Any();
            return result;
        }

        #endregion
    }
}
