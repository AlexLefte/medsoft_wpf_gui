using System;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Exceptions;
using System.ComponentModel;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.ClientCommands
{
    public class EditClientCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly EditClientViewModel _editClientVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public EditClientCommand(EditClientViewModel editClientVM, Workspace workspace, NavigationService navServ)
        {
            _editClientVM = editClientVM;
            _workspace = workspace;
            _navigationService = navServ;

            _editClientVM.PropertyChanged += OnViewModelPropertyChanged;
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
            Client newClient = new Client(_editClientVM.Id, _editClientVM.Nume, _editClientVM.NumeReprezentant, _editClientVM.PrenumeReprezentant,
                _editClientVM.Tara, _editClientVM.Regiune, _editClientVM.Oras, _editClientVM.Adresa, _editClientVM.Telefon);

            try
            {
                await _workspace.UpdateClient(newClient);

                MessageBox.Show("Clientul a fost modificat cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Este posibil sa existe campuri necompletate.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Clientul nu a putut fi modificat.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private bool CheckCanExecute()
        {
            return _editClientVM.CheckCanExecute();
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
