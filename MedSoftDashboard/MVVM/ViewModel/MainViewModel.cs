using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Commands;


namespace MedSoftDashboard.MVVM.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        #region Fields

        // private object _currentView;
        private string _searchBarVisibility;
        private Workspace _workspace;
        private NavigationStore _navigationStore;
        private ViewModelFactory _viewModelFactory;

        #endregion

        #region Properties

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public string SearchBarEnabled
        {
            get => _searchBarVisibility;
            set
            {
                _searchBarVisibility = value;
                OnPropertyChanged(nameof(SearchBarEnabled));
            }
        }
        public ICommand HomeTabCommand { get; }
        public ICommand ClientsTabCommand { get; }
        public ICommand ProjectsTabCommand { get; }
        public ICommand AcquisitionsTabCommand { get; }

        #endregion

        public MainViewModel(Workspace ws, NavigationStore ns)
        {
            _workspace = ws;
            _navigationStore = ns;

            _viewModelFactory = new ViewModelFactory(ws, ns);
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            HomeTabCommand = new NavigateCommand(new NavigationService(_navigationStore, _viewModelFactory.CreateHomeVM));
            ClientsTabCommand = new NavigateCommand(new NavigationService(_navigationStore, _viewModelFactory.CreateClientsVM));
            ProjectsTabCommand = new NavigateCommand(new NavigationService(_navigationStore, _viewModelFactory.CreateProjectsVM));
            AcquisitionsTabCommand = new NavigateCommand(new NavigationService(_navigationStore, _viewModelFactory.CreateAcquisitionsVM));
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        /*private ClientsViewModel CreateClientsVM()
        {
            return ClientsViewModel.LoadViewModel(_workspace, new NavigationService(_navigationStore, CreateAddClientVM));
        }

        private ProjectsViewModel CreateProjectsVM()
        {
            return ProjectsViewModel.LoadViewModel(_workspace, new NavigationService(_navigationStore, CreateAddProjectVM));
        }

        private AddClientViewModel CreateAddClientVM()
        {
            return new AddClientViewModel(_workspace, new NavigationService(_navigationStore, CreateClientsVM));
        }

        private AddProjectViewModel CreateAddProjectVM()
        {
            return new AddProjectViewModel(_workspace, new NavigationService(_navigationStore, CreateProjectsVM));
        }

        private HomeViewModel CreateHomeVM()
        {
            return new HomeViewModel(_workspace);
        }*/
    }
}
