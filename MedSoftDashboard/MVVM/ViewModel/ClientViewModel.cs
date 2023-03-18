using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.Model;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class ClientViewModel : ViewModelBase
    {
        #region Fields

        private readonly Client _client;
        private bool _isSelected;

        #endregion


        #region Properties

        public int Id => _client.Id;
        public string Nume => _client.Nume;
        public string NumeReprezentant => _client.NumeReprezentant;
        public string PrenumeReprezentant => _client.PrenumeReprezentant;
        public string Tara => _client.Tara;
        public string Regiune => _client.Regiune;
        public string Oras => _client.Oras;
        public string Adresa => _client.Adresa;
        public string Telefon => _client.Telefon;

        public Client Client => _client;

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

        public ClientViewModel(Client client)
        {
            _client = client;
        }

        #endregion
    }
}
