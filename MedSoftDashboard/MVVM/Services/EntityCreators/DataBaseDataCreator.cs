using MedSoftDashboard.DbContexts;
using MedSoftDashboard.DTOs;
using MedSoftDashboard.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.EntityCreators
{
    public class DataBaseDataCreator : IDataCreator
    {
        private readonly MedSoftDbContextFactory _dbContextFactory;

        public DataBaseDataCreator(MedSoftDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateClient(Client client)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                ClientDTO clientDTO = ToClientDTO(client);

                context.Clienti.Add(clientDTO);
                await context.SaveChangesAsync();
            }
        }

        private static ClientDTO ToClientDTO(Client client)
        {
            return new ClientDTO(client);
        }


        public async Task CreateProject(Project project)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                ProjectDTO projectDTO = ToProjectDTO(project);

                context.Proiecte.Add(projectDTO);
                await context.SaveChangesAsync();
            }
        }

        private static ProjectDTO ToProjectDTO(Project project)
        {
            return new ProjectDTO(project);
        }

        public async Task CreateAcquisition(Acquisition acquisition)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                AcquisitionDTO acquisitionDTO = ToAcquisitionDTO(acquisition);

                context.Achizitii.Add(acquisitionDTO);
                await context.SaveChangesAsync();
            }
        }

        private static AcquisitionDTO ToAcquisitionDTO(Acquisition acquisition)
        {
            return new AcquisitionDTO(acquisition);
        }
    }
}
