using System;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Exceptions;
using System.ComponentModel;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.ProjectCommands
{
    public class EditProjectCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly EditProjectViewModel _editProjectVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public EditProjectCommand(EditProjectViewModel editProjectVM, Workspace workspace, NavigationService navServ)
        {
            _editProjectVM = editProjectVM;
            _workspace = workspace;
            _navigationService = navServ;

            _editProjectVM.PropertyChanged += OnViewModelPropertyChanged;
        }

        #endregion

        #region Methods

        public override bool CanExecute(object parameter)
        {
            return CheckCanExecute() && base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            Project newProject = new(_editProjectVM.Id, _editProjectVM.Nume, _editProjectVM.Tip, _editProjectVM.Descriere,
                _editProjectVM.DataFinalizare, _editProjectVM.DataActualizare, _editProjectVM.Versiune);

            try
            {
                await _workspace.UpdateProject(newProject);

                MessageBox.Show("Proiectul a fost modificat cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Este posibil sa existe campuri necompletate.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Proiectul nu a putut fi modificat.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CheckCanExecute()
        {
            return _editProjectVM.CheckCanExecute();
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
