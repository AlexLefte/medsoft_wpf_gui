using MedSoftDashboard.MVVM.Commands;
using MedSoftDashboard.MVVM.Commands.ProjectCommands;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class ProjectsViewModel : ViewModelBase
    {
        #region Fields

        private readonly ObservableCollection<ProjectViewModel> _projects;
        private Workspace _workspace;
        private readonly ViewModelFactory _viewModelFactory;
        private bool _isLoading;

        #endregion

        #region Properties

        public List<ProjectViewModel> SelectedProjects;

        public Project? EditedProject
        {
            get => _workspace.EditedProject;
            set => _workspace.EditedProject = value;
        }

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public IEnumerable<ProjectViewModel> Projects => _projects;

        public ICommand EditProjectCommand { get; }
        public ICommand AddProjectCommand { get; }
        public ICommand LoadProjectCommand { get; }
        public ICommand RemoveProjectsCommand { get; }

        #endregion

        #region Constructors

        public ProjectsViewModel(ViewModelFactory vmFactory)
        {
            _workspace = vmFactory.Workspace;
            _projects = new ObservableCollection<ProjectViewModel>();
            _viewModelFactory = vmFactory;

            EditProjectCommand = new NavigateCommand(new NavigationService(vmFactory.NavStore, vmFactory.CreateEditProjectVM));
            AddProjectCommand = new NavigateCommand(new NavigationService(vmFactory.NavStore, vmFactory.CreateAddProjectVM));
            LoadProjectCommand = new LoadProjectsCommand(this, _workspace);
            RemoveProjectsCommand = new RemoveProjectsCommand(this, _workspace, new NavigationService(vmFactory.NavStore, vmFactory.CreateProjectsVM));  
        }

        #endregion

        #region Methods

        public static ProjectsViewModel LoadViewModel(ViewModelFactory vF)
        {
            ProjectsViewModel viewModel = new(vF);

            viewModel.LoadProjectCommand.Execute(null);

            return viewModel;
        }

        public void UpdateProjects(IEnumerable<Project> projects)
        {
            _projects.Clear();

            foreach (Project project in projects)
            {
                ProjectViewModel projectVM = new ProjectViewModel(project);
                _projects.Add(projectVM);
            }

            return;
        }

        #endregion
    }
}
