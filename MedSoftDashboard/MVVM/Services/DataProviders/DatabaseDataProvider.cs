using MedSoftDashboard.DbContexts;
using MedSoftDashboard.DTOs;
using MedSoftDashboard.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.DataProviders
{
    public class DatabaseDataProvider : IDataProvider
    {
        private readonly MedSoftDbContextFactory _dbContextFactory;

        public DatabaseDataProvider(MedSoftDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }


        public async Task<IEnumerable<Client>> GetAllClients()
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ClientDTO> clientDTOs = await context.Clienti.ToListAsync();

                return clientDTOs.Select(client => ToClient(client));
            }
        }

        private async Task<ClientDTO> GetClientById(int clientId)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ClientDTO> clientDTOs = await context.Clienti.ToListAsync();
                return clientDTOs.FirstOrDefault(client => client.Id == clientId);
            }
        }

        private static Client ToClient(ClientDTO clientDTO)
        {
            return new Client(clientDTO.Id, clientDTO.Nume, clientDTO.NumeReprezentant, clientDTO.PrenumeReprezentant,
                clientDTO.Tara, clientDTO.Regiune, clientDTO.Oras, clientDTO.Adresa, clientDTO.Telefon);
        }



        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ProjectDTO> projectDTOs = await context.Proiecte.ToListAsync();

                return projectDTOs.Select(project => ToProject(project));
            }
        }

        private async Task<ProjectDTO> GetProjectById(string projectId)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ProjectDTO> projectDTOs = await context.Proiecte.ToListAsync();
                return projectDTOs.FirstOrDefault(project => project.IdProiect == projectId);
            }
        }

        private static Project ToProject(ProjectDTO projectDTO)
        {
            return new Project(projectDTO.IdProiect, projectDTO.Nume, projectDTO.Tip, projectDTO.Descriere,
                projectDTO.DataFinalizare, projectDTO.DataActualizare, projectDTO.Versiune);
        }



        public async Task<IEnumerable<Acquisition>> GetAllAcquisitions()
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<AcquisitionDTO> acquisitionDTOs = await context.Achizitii.ToListAsync();
                List<Acquisition> result = new List<Acquisition>();
                foreach(AcquisitionDTO acquisitionDTO in acquisitionDTOs)
                {
                    Project selectedProject = ToProject(await GetProjectById(acquisitionDTO.IdProiect));
                    Client selectedClient = ToClient(await GetClientById(acquisitionDTO.IdClient));

                    result.Add(ToAcquisition(acquisitionDTO, selectedClient, selectedProject));
                }

                return result;
            }
        }

        private static Acquisition ToAcquisition(AcquisitionDTO acquisitionDTO, Client client, Project project)
        {
            return new Acquisition(acquisitionDTO.IdAchizitie, acquisitionDTO.IdClient, acquisitionDTO.IdProiect, acquisitionDTO.DataAchizitie,
                acquisitionDTO.Pret, acquisitionDTO.Moneda, client, project);
        }
    }
}
