using MedSoftDashboard.DbContexts;
using MedSoftDashboard.DTOs;
using MedSoftDashboard.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.DataErasers
{
    public class DatabaseEraser : IDataEraser
    {
        private readonly MedSoftDbContextFactory _dbContextFactory;

        public DatabaseEraser(MedSoftDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task RemoveClients(IEnumerable<Client> clients)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ClientDTO> clientDTOs = clients.Select(client => new ClientDTO(client));

                context.Clienti.RemoveRange(clientDTOs);
                await context.SaveChangesAsync();
            }
        }

        public async Task RemoveProjects(IEnumerable<Project> projects)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ProjectDTO> projectDTOs = projects.Select(project => new ProjectDTO(project));

                context.Proiecte.RemoveRange(projectDTOs);
                await context.SaveChangesAsync();
            }
        }

        public async Task RemoveAcquisitions(IEnumerable<Acquisition> acquisitions)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<AcquisitionDTO> acquisitionDTOs = acquisitions.Select(acquisition => new AcquisitionDTO(acquisition));

                context.Achizitii.RemoveRange(acquisitionDTOs);
                await context.SaveChangesAsync();
            }
        }
    }
}