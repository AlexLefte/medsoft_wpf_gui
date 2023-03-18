using System.Collections.Generic;
using System.Windows.Input;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Commands;
using System.Collections.ObjectModel;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Services;
using System.Linq;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Commands.ClientCommands;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class ClientsViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<ClientViewModel> _clients;
        private Workspace _workspace; 
        private readonly NavigationStore _navigationStore;
        private readonly ViewModelFactory _viewModelFactory;
        private bool _isLoading;

        #endregion

        #region Properties

        public IEnumerable<ClientViewModel> Clients => _clients;
        public List<ClientViewModel> SelectedClients;
        public Client? EditedClient
        {
            get => _workspace.EditedClient;
            set => _workspace.EditedClient = value; 
        }
        
        public ICommand EditClientCommand { get; }
        public ICommand AddClientCommand { get; }
        public ICommand LoadClientCommand { get; }
        public ICommand RemoveClientsCommand { get; }

        public bool IsLoading {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        #endregion

        #region Constructors

        public ClientsViewModel(ViewModelFactory vmFactory)
        {
            _workspace = vmFactory.Workspace;
            _clients = new ObservableCollection<ClientViewModel>();
            _viewModelFactory = vmFactory;

            SelectedClients = new List<ClientViewModel>();

            EditClientCommand = new NavigateCommand(new NavigationService(vmFactory.NavStore, vmFactory.CreateEditClientVM));
            AddClientCommand = new NavigateCommand(new NavigationService(vmFactory.NavStore, vmFactory.CreateAddClientVM));
            LoadClientCommand = new LoadClientsCommand(this, _workspace);
            RemoveClientsCommand = new RemoveClientsCommand(this, _workspace, new NavigationService(vmFactory.NavStore, vmFactory.CreateClientsVM));
        }

        #endregion

        #region Methods

        public static ClientsViewModel LoadViewModel(ViewModelFactory vF)
        {
            ClientsViewModel viewModel = new ClientsViewModel(vF);

            viewModel.LoadClientCommand.Execute(null);

            return viewModel;
        }

        public void UpdateClients(IEnumerable<Client> clients)
        {
            _clients.Clear();

            foreach (Client client in clients)
            {
                ClientViewModel clientVM = new ClientViewModel(client);
                _clients.Add(clientVM);
            }

            return;
        }

        #endregion
    }
}
