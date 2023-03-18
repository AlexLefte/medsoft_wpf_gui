using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Services;


namespace MedSoftDashboard.MVVM.ViewModel
{
    public class ViewModelFactory
    {
        #region Fields

        private Workspace _workspace;
        private NavigationStore _navStore;

        #endregion


        #region Properties

        public NavigationStore NavStore => _navStore;
        public Workspace Workspace => _workspace;

        #endregion


        #region Constructors

        public ViewModelFactory(Workspace workspace, NavigationStore navStore)
        {
            _workspace = workspace;
            _navStore = navStore;
        }

        #endregion


        #region Methods

        public HomeViewModel CreateHomeVM()
        {
            return new HomeViewModel(_workspace);
        }


        #region ClientVMs

        public ClientsViewModel CreateClientsVM()
        {
            return ClientsViewModel.LoadViewModel(this);
        }

        public AddClientViewModel CreateAddClientVM()
        {
            return new AddClientViewModel(_workspace, new NavigationService(_navStore, CreateClientsVM));
        }

        public EditClientViewModel CreateEditClientVM()
        {
            return new EditClientViewModel(_workspace, new NavigationService(_navStore, CreateClientsVM));
        }

        #endregion


        #region Project VMs

        public ProjectsViewModel CreateProjectsVM()
        {
            return ProjectsViewModel.LoadViewModel(this);
        }

        public AddProjectViewModel CreateAddProjectVM()
        {
            return new AddProjectViewModel(_workspace, new NavigationService(_navStore, CreateProjectsVM));
        }

        public EditProjectViewModel CreateEditProjectVM()
        {
            return new EditProjectViewModel(_workspace, new NavigationService(_navStore, CreateProjectsVM));
        }

        #endregion


        #region Acquisition VMs

        public AcquisitionsViewModel CreateAcquisitionsVM()
        {
            return AcquisitionsViewModel.LoadViewModel(this);
        }

        public AddAcquisitionViewModel CreateAddAcquisitionVM()
        {
            return new AddAcquisitionViewModel(_workspace, new NavigationService(_navStore, CreateAcquisitionsVM));
        }

        public EditAcquisitionViewModel CreateEditAcquisitionVM()
        {
            return new EditAcquisitionViewModel(_workspace, new NavigationService(_navStore, CreateAcquisitionsVM));
        }

        #endregion

        #endregion
    }
}
