using System;
using System.Linq;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Exceptions;
using System.ComponentModel;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.AcquisitionCommands
{
    public class RemoveAcquisitionsCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly AcquisitionsViewModel _AcquisitionsVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public RemoveAcquisitionsCommand(AcquisitionsViewModel AcquisitionsVM, Workspace workspace, NavigationService navServ)
        {
            _AcquisitionsVM = AcquisitionsVM;
            _workspace = workspace;
            _navigationService = navServ;

            _AcquisitionsVM.PropertyChanged += OnViewModelPropertyChanged;
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
                await _workspace.RemoveAcquisitions(_AcquisitionsVM.SelectedAcquisitions.Select(AcquisitionVM => AcquisitionVM.Acquisition).ToList());

                MessageBox.Show("Achizitiile au fost eliminate cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (NoElementSelectedException)
            {
                MessageBox.Show("Nu ati selectat nicio achizitie.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Achizitiile nu au putut fi eliminate.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
