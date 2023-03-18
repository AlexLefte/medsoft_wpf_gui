using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Model
{
    public class Project
    {
        #region Properties
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Tip { get; set; }
        public string Descriere { get; set; }
        public DateTime DataFinalizare { get; set; }
        public DateTime DataActualizare { get; set; }
        public string Versiune { get; set; }
        public string DisplayName => Id + ", " + Nume;
        #endregion

        #region Constructors

        public Project() { }
        public Project(string id, string nume, string tip, string descriere, DateTime dataFin,
            DateTime dataAct, string versiune)
        {
            Id = id;
            Nume = nume;
            Tip = tip;
            Descriere = descriere;
            DataFinalizare = dataFin;
            DataActualizare = dataAct;
            Versiune = versiune;
        }
        #endregion
    }
}
