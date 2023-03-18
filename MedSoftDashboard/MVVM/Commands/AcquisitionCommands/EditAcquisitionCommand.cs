using System;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Exceptions;
using System.ComponentModel;
using System.Windows;

namespace MedSoftDashboard.MVVM.Commands.AcquisitionCommands
{
    public class EditAcquisitionCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly EditAcquisitionViewModel _editAcquisitionVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public EditAcquisitionCommand(EditAcquisitionViewModel editAcquisitionVM, Workspace workspace, NavigationService navServ)
        {
            _editAcquisitionVM = editAcquisitionVM;
            _workspace = workspace;
            _navigationService = navServ;

            _editAcquisitionVM.PropertyChanged += OnViewModelPropertyChanged;
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
            Acquisition newAcquisition = new (_editAcquisitionVM.Id, _editAcquisitionVM.IdClient, _editAcquisitionVM.IdProiect,
                _editAcquisitionVM.DataAchizitie, _editAcquisitionVM.Pret, _editAcquisitionVM.Moneda, _editAcquisitionVM.SelectedClient, 
                _editAcquisitionVM.SelectedProject);

            try
            {
                await _workspace.UpdateAcquisition(newAcquisition);

                MessageBox.Show("Achizitia a fost modificata cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Este posibil sa existe campuri necompletate.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception) 
            {
                MessageBox.Show("Achizitia nu a putut fi modificata.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private bool CheckCanExecute()
        {
            return _editAcquisitionVM.CheckCanExecute();
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
