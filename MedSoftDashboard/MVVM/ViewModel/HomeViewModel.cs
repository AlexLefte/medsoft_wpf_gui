using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.Model;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        #region Fields

        private Workspace _workspace;
        private int _clientCount;
        private int _projectCount;
        private int _acquisitionCount;
        private double _records;

        private Dictionary<string, double> CurrencyRates = new Dictionary<string, double>()
        {
            {"RON", 0.2},
            { "EUR", 1},
            { "USD", 0.92},
        };

        #endregion

        #region Properties

        public int ClientCount { get => _clientCount; 
            set
            {
                _clientCount = value;
                OnPropertyChanged(nameof(ClientCount));
            }
        }

        public int ProjectCount
        {
            get => _projectCount;
            set
            {
                _projectCount = value;
                OnPropertyChanged(nameof(ProjectCount));
            }
        }

        public int AcquisitionCount
        {
            get => _acquisitionCount;
            set
            {
                _acquisitionCount = value;
                OnPropertyChanged(nameof(AcquisitionCount));
            }
        }

        public double Records 
        { 
            get => _records; 
            set
            {
                _records = value;
                OnPropertyChanged(nameof(Records));
            }
        }

        #endregion

        #region Constructor

        public HomeViewModel(Workspace ws)
        {
            _workspace = ws;
            /*_workspace.GetAllData();
            UpdateStats();*/
        }

        #endregion

        #region Methods

        /*public void UpdateStats()
        {
            ClientCount = _workspace.ClientsList.Count();
            ProjectCount = _workspace.ProjectsList.Count();
            ComputeRecords();
        }

        private void ComputeRecords()
        {
            double records = 0;
            foreach (Acquisition acq in _workspace.AcquisitionsList)
            {
                records += acq.Pret;
            }

            Records = records;
        }*/

        #endregion
    }
}
