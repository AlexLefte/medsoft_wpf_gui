using MedSoftDashboard.MVVM.Exceptions;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.ProjectCommands
{
    public class AddProjectCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly AddProjectViewModel _addProjectVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public AddProjectCommand(AddProjectViewModel addProjectVM, Workspace ws, NavigationService navServ)
        {
            _addProjectVM = addProjectVM;
            _workspace = ws;
            _navigationService = navServ;

            _addProjectVM.PropertyChanged += OnViewModelPropertyChanged;
        }

        #endregion

        #region Methods

        public override bool CanExecute(object parameter)
        {
            var result = CheckCanExecute() && base.CanExecute(parameter);
            return result;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            Project newProject = new Project(_addProjectVM.Id, _addProjectVM.Nume, _addProjectVM.Tip, _addProjectVM.Descriere,
                _addProjectVM.DataFinalizare, _addProjectVM.DataActualizare, _addProjectVM.Versiune);

            try
            {
                await _workspace.AddProject(newProject);

                MessageBox.Show("Projectul a fost adugat cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (ProjectConflictException)
            {
                MessageBox.Show("Projectul a fost adugat deja.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Projectul nu a putut fi adaugat.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private bool CheckCanExecute()
        {
            return _addProjectVM.CheckCanExecute();
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
