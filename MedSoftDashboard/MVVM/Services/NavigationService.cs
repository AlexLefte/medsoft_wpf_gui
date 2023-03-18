using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Stores;

namespace MedSoftDashboard.MVVM.Services
{
    public class NavigationService
    {
        #region Fields

        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;

        #endregion

        #region Constructors

        public NavigationService(NavigationStore navStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navStore;
            _createViewModel = createViewModel;
        }

        #endregion

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
