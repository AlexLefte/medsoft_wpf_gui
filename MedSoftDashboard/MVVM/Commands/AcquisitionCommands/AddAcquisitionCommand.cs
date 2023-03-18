using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.Exceptions;
using System.ComponentModel;
using System.Windows;
using MedSoftDashboard.MVVM.Stores;

namespace MedSoftDashboard.MVVM.Commands.AcquisitionCommands
{
    public class AddAcquisitionCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly AddAcquisitionViewModel _addAcquisitionVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public AddAcquisitionCommand(AddAcquisitionViewModel addAcquisitionVM, Workspace workspace, NavigationService navServ)
        {
            _addAcquisitionVM = addAcquisitionVM;
            _workspace = workspace;
            _navigationService = navServ;

            _addAcquisitionVM.PropertyChanged += OnViewModelPropertyChanged;
        }

        #endregion

        #region Methods

        public override bool CanExecute(object parameter)
        {
            return _addAcquisitionVM.CheckCanExecute() && base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            Acquisition newAcquisition = new Acquisition(_addAcquisitionVM.Id, _addAcquisitionVM.IdClient, _addAcquisitionVM.IdProiect,
                _addAcquisitionVM.DataAchizitie, _addAcquisitionVM.Pret, _addAcquisitionVM.Moneda, _addAcquisitionVM.SelectedClient,
                _addAcquisitionVM.SelectedProject);

            try
            {
                await _workspace.AddAcquisition(newAcquisition);

                MessageBox.Show("Achizitia a fost adaugata cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (Exception)
            {
                MessageBox.Show("Achizitia nu a putut fi adaugata.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
