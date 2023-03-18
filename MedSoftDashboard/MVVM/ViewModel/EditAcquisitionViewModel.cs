using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MedSoftDashboard.MVVM.Commands;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Commands.AcquisitionCommands;
using System.Collections;
using System.ComponentModel;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class EditAcquisitionViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        #region Fields

        private Workspace _workspace;
        private int _id;
        private int _idClient;
        private string _idProiect;
        private DateTime _dataAchizitie;
        private double _pret;
        private string _moneda;
        private Client _client;
        private List<Client> _clients;
        private Project _project;
        private List<Project> _projects;

        #endregion

        #region Properties

        public int Id { get; set; }

        public int IdClient
        {
            get { return _idClient; }
            set
            {
                _idClient = value;
                OnPropertyChanged(nameof(IdClient));
            }
        }
        public string IdProiect
        {
            get { return _idProiect; }
            set
            {
                _idProiect = value;
                OnPropertyChanged(nameof(IdProiect));
            }
        }
        public DateTime DataAchizitie
        {
            get { return _dataAchizitie; }
            set
            {
                _dataAchizitie = value;
                OnPropertyChanged(nameof(DataAchizitie));

                ClearErrors(nameof(DataAchizitie));

                if (DateTime.Compare(DataAchizitie, DateTime.Now) > 0)
                {
                    AddError("Data achizitie incorecta.", nameof(DataAchizitie));
                }
            }
        }
        public double Pret
        {
            get { return _pret; }
            set
            {
                _pret = value;
                OnPropertyChanged(nameof(Pret));

                ClearErrors(nameof(Pret));

                if (Pret <= 0)
                {
                    AddError("Pret >= 0", nameof(Pret));
                }
            }
        }
        public string Moneda
        {
            get { return _moneda; }
            set
            {
                _moneda = value;
                OnPropertyChanged(nameof(Moneda));
            }
        }
        public Client SelectedClient
        {
            get { return _client; }
            set
            {
                _client = value;
                OnPropertyChanged(nameof(Client));
            }
        }

        public List<Client> Clients
        {
            get { return _clients; }
            set
            {
                _clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }

        public Project SelectedProject
        {
            get { return _project; }
            set
            {
                _project = value;
                OnPropertyChanged(nameof(Project));
            }
        }

        public List<Project> Projects
        {
            get { return _projects; }
            set
            {
                _projects = value;
                OnPropertyChanged(nameof(Projects));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        #endregion

        #region Constructor

        public EditAcquisitionViewModel(Workspace workspace, NavigationService navServ)
        {
            _workspace = workspace;
            _propertyNameToErrorsDictionary = new Dictionary<string, string>();

            Acquisition? selectedAcquisition = workspace.EditedAcquisition;
            Id = selectedAcquisition?.Id ?? 0;
            IdClient = selectedAcquisition?.IdClient ?? 0;
            IdProiect = selectedAcquisition?.IdProiect?? string.Empty;
            DataAchizitie = selectedAcquisition?.DataAchizitie ?? DateTime.Now;
            Pret = selectedAcquisition?.Pret ?? 0;
            Moneda = selectedAcquisition?.Moneda ?? string.Empty;
            SelectedClient = selectedAcquisition.Client;
            SelectedProject = selectedAcquisition.Project;

            Clients = workspace.ClientsList.ToList();
            Projects = workspace.ProjectsList.ToList();

            SubmitCommand = new EditAcquisitionCommand(this, workspace, navServ);
            CancelCommand = new NavigateCommand(navServ);
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
            return (!_propertyNameToErrorsDictionary.Any()) && (Moneda != null)
                && (SelectedClient != null) && (SelectedProject != null);
        }

        #endregion
    }
}
