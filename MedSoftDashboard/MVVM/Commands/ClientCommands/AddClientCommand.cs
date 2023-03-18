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

namespace MedSoftDashboard.MVVM.Commands.ClientCommands
{
    public class AddClientCommand : AsyncCommandBase
    {
        private readonly Workspace _workspace;
        private readonly AddClientViewModel _addClientVM;
        private readonly NavigationService _navigationService;

        #region Constructors

        public AddClientCommand(AddClientViewModel addClientVM, Workspace workspace, NavigationService navServ)
        {
            _addClientVM = addClientVM;
            _workspace = workspace;
            _navigationService = navServ;

            _addClientVM.PropertyChanged += OnViewModelPropertyChanged;
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
            Client newClient = new Client(_addClientVM.Id, _addClientVM.Nume, _addClientVM.NumeReprezentant, _addClientVM.PrenumeReprezentant,
                _addClientVM.Tara, _addClientVM.Regiune, _addClientVM.Oras, _addClientVM.Adresa, _addClientVM.Telefon);

            try
            {
                await _workspace.AddClient(newClient);

                MessageBox.Show("Clientul a fost adugat cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigationService.Navigate();
            }
            catch (ClientConflictException)
            {
                MessageBox.Show("Clientul a fost adugat deja.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Clientul nu a putut fi adaugat.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private bool CheckCanExecute()
        {
            return _addClientVM.CheckCanExecute();
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }
        #endregion
    }
}
