using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Model
{
    public class Client
    {
        #region Properties
        public int Id { get; }
        public string Nume { get; set; }
        public string NumeReprezentant { get; set; }
        public string PrenumeReprezentant { get; set; }
        public string Tara { get; set; }
        public string Regiune { get; set; }
        public string Oras { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string DisplayName => Id.ToString() + ", " + Nume;
        #endregion

        #region Constructors
        public Client(int id,string nume, string numeRepr, string prenumeRepr, string tara,
            string regiune, string oras, string adresa, string telefon)
        {
            Id = id;
            Nume = nume;
            NumeReprezentant = numeRepr;
            PrenumeReprezentant = prenumeRepr;
            Tara = tara;
            Regiune = regiune;
            Oras = oras;
            Adresa = adresa;
            Telefon = telefon;
        }
        #endregion

        #region Methods
        /*public override string ToString()
        {
            return Id.ToString() + ", " + Nume + ", Reprezentant: " + NumeReprezentant + " " + PrenumeReprezentant;
        }*/

        public bool Conflicts(Client newClient)
        {
            if (newClient.Id != Id && newClient.Nume != Nume)
            {
                return false;
            }

            return true;
        }

        #endregion

    }
}
