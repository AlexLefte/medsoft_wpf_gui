using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.Model;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class AcquisitionViewModel : ViewModelBase
    {
        #region Fields

        private readonly Acquisition _Acquisition;
        private bool _isSelected;

        #endregion

        #region Properties

        public int Id => _Acquisition.Id;
        public int IdClient => _Acquisition.IdClient;
        public string IdProiect => _Acquisition.IdProiect;
        public DateTime? DataAchizitie => _Acquisition.DataAchizitie ?? DateTime.Now;
        public double Pret => _Acquisition.Pret;
        public string Moneda => _Acquisition.Moneda;
        public Client Client => _Acquisition.Client;
        public Project Project => _Acquisition.Project;

        public Acquisition Acquisition => _Acquisition;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }

        #endregion


        #region Constructors

        public AcquisitionViewModel(Acquisition Acquisition)
        {
            _Acquisition = Acquisition;
        }

        #endregion
    }
}
