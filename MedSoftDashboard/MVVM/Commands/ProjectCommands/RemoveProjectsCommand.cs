using System;
using System.Linq;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Exceptions;
using System.ComponentModel;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.ProjectCommands
{
    public class RemoveProjectsCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly ProjectsViewModel _projectsVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public RemoveProjectsCommand(ProjectsViewModel projectsVM, Workspace workspace, NavigationService navServ)
        {
            _projectsVM = projectsVM;
            _workspace = workspace;
            _navigationService = navServ;

            _projectsVM.PropertyChanged += OnViewModelPropertyChanged;
        }

        #endregion

        #region Methods

        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _workspace.RemoveProjects(_projectsVM.SelectedProjects.Select(projectVM => projectVM.Project).ToList());

                MessageBox.Show("Proiectele au fost eliminate cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (NoElementSelectedException)
            {
                MessageBox.Show("Nu ati selectat niciun proiect.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Proiectele nu au putut fi eliminate.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
