using MedSoftDashboard.DbContexts;
using MedSoftDashboard.DTOs;
using MedSoftDashboard.MVVM.Model;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.DataEditors
{
    public class DatabaseDataEditor : IDataEditor
    {
        private readonly MedSoftDbContextFactory _dbContextFactory;

        public DatabaseDataEditor(MedSoftDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }


        #region Client

        public async Task UpdateClient(Client client)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                ClientDTO clientDTO = ToClientDTO(client);

                context.Clienti.Update(clientDTO);
                await context.SaveChangesAsync();
            }
        }

        private static ClientDTO ToClientDTO(Client client)
        {
            return new ClientDTO(client);
        }

        #endregion


        #region Project

        public async Task UpdateProject(Project project)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                ProjectDTO projectDTO = ToProjectDTO(project);

                context.Proiecte.Update(projectDTO);
                await context.SaveChangesAsync();
            }
        }

        private static ProjectDTO ToProjectDTO(Project project)
        {
            return new ProjectDTO(project);
        }

        #endregion


        #region Acquisition

        public async Task UpdateAcquisition(Acquisition acquisition)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                AcquisitionDTO acquisitionDTO = ToAcquisitionDTO(acquisition);
                context.Achizitii.Update(acquisitionDTO);

                await context.SaveChangesAsync();
            }
        }

        private static AcquisitionDTO ToAcquisitionDTO(Acquisition acquisition)
        {
            return new AcquisitionDTO(acquisition);
        }

        #endregion
    }
}
