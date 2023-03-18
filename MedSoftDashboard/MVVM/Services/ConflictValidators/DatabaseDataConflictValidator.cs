using MedSoftDashboard.DbContexts;
using MedSoftDashboard.DTOs;
using MedSoftDashboard.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.ConflictValidators
{
    public class DatabaseDataConflictValidator : IDataConflictValidator
    {
        private readonly MedSoftDbContextFactory _dbContextFactory;

        public DatabaseDataConflictValidator(MedSoftDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<Client> GetConflictingClient(Client client)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                ClientDTO clientDTO = await context.Clienti
                    .Where(c => c.Id == client.Id)
                    .Where(c => c.Nume == client.Nume)
                    .FirstOrDefaultAsync();

                if (clientDTO == null)
                {
                    return null;
                }

                return ToClient(clientDTO);
            }
        }

        private static Client ToClient(ClientDTO clientDTO)
        {
            return new Client(clientDTO.Id, clientDTO.Nume, clientDTO.NumeReprezentant, clientDTO.PrenumeReprezentant,
                clientDTO.Tara, clientDTO.Regiune, clientDTO.Oras, clientDTO.Adresa, clientDTO.Telefon);
        }

        public async Task<Project> GetConflictingProject(Project project)
        {
            using (MedSoftDbContext context = _dbContextFactory.CreateDbContext())
            {
                ProjectDTO projectDTO = await context.Proiecte
                    .Where(c => c.IdProiect == project.Id)
                    .Where(c => c.Nume == project.Nume)
                    .FirstOrDefaultAsync();

                if (projectDTO == null)
                {
                    return null;
                }

                return ToProject(projectDTO);
            }
        }

        private static Project ToProject(ProjectDTO projectDTO)
        {
            return new Project(projectDTO.IdProiect, projectDTO.Nume, projectDTO.Tip, projectDTO.Descriere,
                projectDTO.DataFinalizare, projectDTO.DataActualizare, projectDTO.Versiune);
        }
    }
}
