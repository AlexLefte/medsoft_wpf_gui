/*using System;
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

namespace MedSoftDashboard.MVVM.Commands.HomeStatsCommands
{
    public class AddHomeStatsCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly HomeViewModel _homeVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public AddHomeStatsCommand(HomeViewModel homeVM, Workspace workspace, NavigationService navServ)
        {
            _homeVM = homeVM;
            _workspace = workspace;
            _navigationService = navServ;

            _homeVM.PropertyChanged += OnViewModelPropertyChanged;
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
                _workspace.GetAllData();
                _homeVM.UpdateStats();
               
                _navigationService.Navigate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele nu au putut fi extrase din baza de date.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        *//*private bool CheckCanExecute()
        {
            return _homeVM.CheckCanExecute();
        }*//*

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
*/