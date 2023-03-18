using System;
using System.Linq;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Exceptions;
using System.ComponentModel;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.ClientCommands
{
    public class RemoveClientsCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly ClientsViewModel _clientsVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public RemoveClientsCommand(ClientsViewModel clientsVM, Workspace workspace, NavigationService navServ)
        {
            _clientsVM = clientsVM;
            _workspace = workspace;
            _navigationService = navServ;

            _clientsVM.PropertyChanged += OnViewModelPropertyChanged;
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
                await _workspace.RemoveClients(_clientsVM.SelectedClients.Select(clientVM => clientVM.Client).ToList());

                MessageBox.Show("Clientii au fost eliminati cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (NoElementSelectedException)
            {
                MessageBox.Show("Nu ati selectat niciun client.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Clientii nu au putut fi eliminati.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
