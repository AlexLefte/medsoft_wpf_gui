using MedSoftDashboard.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedSoftDashboard.MVVM.View
{
    /// <summary>
    /// Interaction logic for ClientsView.xaml
    /// </summary>
    public partial class ClientsView : UserControl
    {
        public ClientsView()
        {
            InitializeComponent();
        }

        private void ClientsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var clientsVM = (ClientsViewModel)DataContext;

            if (clientsVM != null)
            {
                clientsVM.SelectedClients = clientsList.SelectedItems.Cast<ClientViewModel>().ToList();

                if (clientsList.SelectedItems?.Count != 1)
                {
                    clientsVM.EditedClient = null;
                    editButton.IsEnabled = false;
                    editButton.Background = Brushes.LightGray;
                }
                else
                {
                    clientsVM.EditedClient = ((ClientViewModel)clientsList.SelectedItem).Client;
                    editButton.IsEnabled = true;
                    editButton.Background = Brushes.Green;
                }

                if (clientsList.SelectedItems?.Count == 0)
                {
                    deleteButton.IsEnabled = false;
                    deleteButton.Background = Brushes.LightGray;
                }
                else
                {
                    deleteButton.IsEnabled = true;
                    deleteButton.Background = Brushes.Red;
                }
            }               
        }
    }
}
