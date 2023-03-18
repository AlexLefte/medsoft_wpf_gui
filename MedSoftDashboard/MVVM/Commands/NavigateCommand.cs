using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Services;
using MedSoftDashboard.MVVM.ViewModel;

namespace MedSoftDashboard.MVVM.Commands
{
    public class NavigateCommand : CommandBase
    {
        #region Fields

        private readonly NavigationService _navigationService;

        #endregion

        #region Constructors

        public NavigateCommand(NavigationService navServ)
        {
            _navigationService = navServ;
        }

        #endregion

        #region Methods

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }

        #endregion
    }
}
