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
    public class ClientDTO
    {
        #region Properties

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idclient")]
        public int Id { get; set; }

        [StringLength(45)]
        [Column("nume")]
        public string Nume { get; set; }

        [StringLength(45)]
        [Column("nume_reprezentant")]
        public string NumeReprezentant { get; set; }

        [StringLength(45)]
        [Column("prenume_reprezentant")]
        public string PrenumeReprezentant { get; set; }

        [StringLength(45)]
        [Column("tara")]
        public string Tara { get; set; }

        [StringLength(45)]
        [Column("regiune")]
        public string Regiune { get; set; }

        [StringLength(45)]
        [Column("oras")]
        public string Oras { get; set; }

        [StringLength(45)]
        [Column("adresa")]
        public string Adresa { get; set; }

        [StringLength(45)]
        [Column("telefon")]
        public string Telefon { get; set; }

        #endregion

        #region Constructors

        public ClientDTO() { }
        public ClientDTO(Client client)
        {
            Id = client.Id;
            Nume = client.Nume ?? "";
            NumeReprezentant = client.NumeReprezentant ?? "";
            PrenumeReprezentant = client.PrenumeReprezentant ?? "";
            Tara = client.Tara ?? "";
            Regiune = client.Regiune ?? "";
            Oras = client.Oras ?? "";
            Adresa = client.Adresa ?? "";
            Telefon = client.Telefon ?? "";
        }

        #endregion
    }
}
