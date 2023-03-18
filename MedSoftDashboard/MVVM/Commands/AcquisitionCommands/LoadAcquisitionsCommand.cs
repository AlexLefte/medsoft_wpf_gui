using MedSoftDashboard.DTOs;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.AcquisitionCommands
{
    public class LoadAcquisitionsCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly AcquisitionsViewModel _AcquisitionsVM;

        public LoadAcquisitionsCommand(AcquisitionsViewModel AcquisitionsVM, Workspace workspace)
        {
            _workspace = workspace;
            _AcquisitionsVM = AcquisitionsVM;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _AcquisitionsVM.IsLoading = true;

            try
            {
                IEnumerable<Acquisition> Acquisitions = await _workspace.GetAllAcquisitions();

                _AcquisitionsVM.UpdateAcquisitions(Acquisitions);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Achizitiile nu au putut fi extrase din baza de date.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _AcquisitionsVM.IsLoading = false;
            }
        }
    }
}
