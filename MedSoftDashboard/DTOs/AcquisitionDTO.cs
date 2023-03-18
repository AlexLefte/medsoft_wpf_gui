using MedSoftDashboard.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.DTOs
{
    public class AcquisitionDTO
    {
        #region Properties 

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idachizitie")]
        public int IdAchizitie { get; set; }

        [StringLength(45)]
        [Column("idclient")]
        public int IdClient { get; set; }

        [StringLength(45)]
        [Column("idproiect")]
        public string IdProiect { get; set; }

        [StringLength(45)]
        [Column("data_achizitie")]
        public DateTime DataAchizitie { get; set; }

        [StringLength(45)]
        [Column("pret")]
        public double Pret { get; set; }

        [StringLength(45)]
        [Column("moneda")]
        public string Moneda { get; set; }

        #endregion

        #region Constructors

        public AcquisitionDTO() { }

        public AcquisitionDTO(Acquisition Acquisition)
        {
            IdAchizitie = Acquisition.Id;
            IdClient = Acquisition.IdClient;
            IdProiect = Acquisition.IdProiect;
            DataAchizitie = Acquisition.DataAchizitie ?? DateTime.Now;
            Pret = Acquisition.Pret;
            Moneda = Acquisition.Moneda;
        }

        #endregion
    }
}
