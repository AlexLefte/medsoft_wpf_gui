using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.ProjectCommands
{
    public class LoadProjectsCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly ProjectsViewModel _projectsVM;

        public LoadProjectsCommand(ProjectsViewModel projectsVM, Workspace workspace)
        {
            _workspace = workspace;
            _projectsVM = projectsVM;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _projectsVM.IsLoading = true;

            try
            {
                IEnumerable<Project> Projects = await _workspace.GetAllProjects();

                _projectsVM.UpdateProjects(Projects);

                _workspace.ProjectsList = Projects.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Proiectele nu au putut fi extrase din baza de date.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _projectsVM.IsLoading = false;
            }
        }
    }
}
