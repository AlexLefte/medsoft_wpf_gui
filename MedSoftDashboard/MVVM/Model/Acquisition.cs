using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Model
{
    public class Acquisition
    {
        #region Properties
        public int Id { get; }
        public int IdClient { get; }
        public string IdProiect { get; }
        public DateTime? DataAchizitie { get; }
        public double Pret { get; }
        public string Moneda { get; }
        public Client Client { get; }
        public Project Project { get; }
        #endregion

        #region Constructors
        public Acquisition(int id, int idClient, string idProiect, DateTime? dataAq,
            double pret, string moneda, Client client, Project project)
        {
            Id = id;
            IdClient = idClient;
            IdProiect = idProiect;
            DataAchizitie = dataAq ?? DateTime.Now;
            Pret = pret;
            Moneda = moneda;
            Client = client;
            Project = project;
        }
        #endregion
    }
}