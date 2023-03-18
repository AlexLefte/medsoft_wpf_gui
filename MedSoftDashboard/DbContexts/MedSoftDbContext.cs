using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.DTOs;

namespace MedSoftDashboard.DbContexts
{
    public class MedSoftDbContext : DbContext
    {
        #region Properties
        public DbSet<ClientDTO> Clienti { get; set; }
        public DbSet<ProjectDTO> Proiecte { get; set; }
        public DbSet<AcquisitionDTO> Achizitii { get; set; }

        #endregion

        #region Constructors
        public MedSoftDbContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientDTO>(entity =>
            {
                entity.HasKey(c => c.Id);
            });

            modelBuilder.Entity<ProjectDTO>(entity =>
            {
                entity.HasKey(p => p.IdProiect);
            });

            modelBuilder.Entity<AcquisitionDTO>(entity =>
            {
                entity.HasKey(p => p.IdAchizitie);
            });
        }

        #endregion
    }
}
