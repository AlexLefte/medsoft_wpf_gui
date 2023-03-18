using MedSoftDashboard.MVVM.ViewModel;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AcquisitionsView.xaml
    /// </summary>
    public partial class AcquisitionsView : UserControl
    {
        public AcquisitionsView()
        {
            InitializeComponent();
        }

        private void AcquisitionsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var AcquisitionsVM = (AcquisitionsViewModel)DataContext;

            if (AcquisitionsVM != null)
            {
                AcquisitionsVM.SelectedAcquisitions = acquisitionsList.SelectedItems.Cast<AcquisitionViewModel>().ToList();

                if (acquisitionsList.SelectedItems?.Count != 1)
                {
                    AcquisitionsVM.EditedAcquisition = null;
                    editButton.IsEnabled = false;
                    editButton.Background = Brushes.LightGray;
                }
                else
                {
                    AcquisitionsVM.EditedAcquisition = ((AcquisitionViewModel)acquisitionsList.SelectedItem).Acquisition;
                    editButton.IsEnabled = true;
                    editButton.Background = Brushes.Green;
                }

                if (acquisitionsList.SelectedItems?.Count == 0)
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
