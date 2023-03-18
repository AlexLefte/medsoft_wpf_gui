using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.ClientCommands
{
    public class LoadClientsCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly ClientsViewModel _clientsVM;

        public LoadClientsCommand(ClientsViewModel clientsVM, Workspace workspace)
        {
            _workspace = workspace;
            _clientsVM = clientsVM;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _clientsVM.IsLoading = true;

            try
            {
                IEnumerable<Client> clients = await _workspace.GetAllClients();
                _workspace.ClientsList = clients;

                _clientsVM.UpdateClients(clients);
            }
            catch (Exception)
            {
                MessageBox.Show("Clientii nu au putut fi extrasi din baza de date.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _clientsVM.IsLoading = false;
            }
        }
    }
}
