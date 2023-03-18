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
    public class ProjectDTO
    {
        #region Properties 

        [Key, Column("idproiect")]
        public string IdProiect { get; set; }

        [StringLength(45)]
        [Column("nume")]
        public string Nume { get; set; }

        [StringLength(45)]
        [Column("tip")]
        public string Tip { get; set; }

        [StringLength(45)]
        [Column("descriere")]
        public string Descriere { get; set; }

        // ToString("yyyy-MM-dd")
        [StringLength(45)]
        [Column("data_finalizare")]
        public DateTime DataFinalizare { get; set; }

        [StringLength(45)]
        [Column("data_actualizare")]
        public DateTime DataActualizare { get; set; }

        [StringLength(45)]
        [Column("versiune")]
        public string Versiune { get; set; }

        #endregion

        #region Constructors

        public ProjectDTO() { }

        public ProjectDTO(Project project)
        {
            IdProiect = project.Id;
            Nume = project.Nume ?? "";
            Tip = project.Tip ?? "";
            Descriere = project.Descriere ?? "";
            DataFinalizare = project.DataFinalizare;
            DataActualizare = project.DataActualizare;
            Versiune = project.Versiune ?? "";
        }

        #endregion
    }
}
