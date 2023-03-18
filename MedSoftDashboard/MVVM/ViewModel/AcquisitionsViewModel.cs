using System.Collections.Generic;
using System.Windows.Input;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Commands;
using System.Collections.ObjectModel;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Services;
using System.Linq;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Commands.AcquisitionCommands;
using System;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class AcquisitionsViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<AcquisitionViewModel> _Acquisitions;
        private Workspace _workspace;
        private readonly NavigationStore _navigationStore;
        private readonly ViewModelFactory _viewModelFactory;
        private bool _isLoading;

        #endregion

        #region Properties

        public IEnumerable<AcquisitionViewModel> Acquisitions => _Acquisitions;
        public List<AcquisitionViewModel> SelectedAcquisitions;
        public Acquisition? EditedAcquisition
        {
            get => _workspace.EditedAcquisition;
            set => _workspace.EditedAcquisition = value;
        }

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public ICommand EditAcquisitionCommand { get; }
        public ICommand AddAcquisitionCommand { get; }
        public ICommand LoadAcquisitionCommand { get; }
        public ICommand RemoveAcquisitionsCommand { get; }

        #endregion

        #region Constructors

        public AcquisitionsViewModel(ViewModelFactory vmFactory)
        {
            _workspace = vmFactory.Workspace;
            _Acquisitions = new ObservableCollection<AcquisitionViewModel>();
            _viewModelFactory = vmFactory;

            SelectedAcquisitions = new List<AcquisitionViewModel>();

            EditAcquisitionCommand = new NavigateCommand(new NavigationService(vmFactory.NavStore, vmFactory.CreateEditAcquisitionVM));
            AddAcquisitionCommand = new NavigateCommand(new NavigationService(vmFactory.NavStore, vmFactory.CreateAddAcquisitionVM));
            LoadAcquisitionCommand = new LoadAcquisitionsCommand(this, _workspace);
            RemoveAcquisitionsCommand = new RemoveAcquisitionsCommand(this, _workspace, new NavigationService(vmFactory.NavStore, vmFactory.CreateAcquisitionsVM));
        }

        #endregion

        #region Methods

        public static AcquisitionsViewModel LoadViewModel(ViewModelFactory vF)
        {
            AcquisitionsViewModel viewModel = new AcquisitionsViewModel(vF);

            viewModel.LoadAcquisitionCommand.Execute(null);

            return viewModel;
        }

        public void UpdateAcquisitions(IEnumerable<Acquisition> Acquisitions)
        {
            _Acquisitions.Clear();

            try
            {
                foreach (Acquisition Acquisition in Acquisitions)
                {
                    AcquisitionViewModel AcquisitionVM = new AcquisitionViewModel(Acquisition);
                    _Acquisitions.Add(AcquisitionVM);
                }
            }
            catch (Exception ex)
            {

            }

            return;
        }

        #endregion
    }
}
