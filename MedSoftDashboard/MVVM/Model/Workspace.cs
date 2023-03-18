using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.Exceptions;
using MedSoftDashboard.MVVM.Services;

namespace MedSoftDashboard.MVVM.Model
{
    public class Workspace
    {
        #region Fields

        private readonly DatabaseServices dbServices;
        private bool _isLoading;

        #endregion

        #region Properties

        public Client? EditedClient;
        public Project? EditedProject;
        public Acquisition? EditedAcquisition;

        public IEnumerable<Client> ClientsList;
        public IEnumerable<Project> ProjectsList;

        #endregion

        #region Constructor

        public Workspace(DatabaseServices databaseServices)
        {
            dbServices = databaseServices;
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await dbServices.DataProvider.GetAllClients();
        }

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            return await dbServices.DataProvider.GetAllProjects();
        }

        public async Task<IEnumerable<Acquisition>> GetAllAcquisitions()
        {
            ClientsList = await dbServices.DataProvider.GetAllClients();
            ProjectsList = await dbServices.DataProvider.GetAllProjects();

            return await dbServices.DataProvider.GetAllAcquisitions();
        }

        /*public async void GetAllData()
        {
            ClientsList = await dbServices.DataProvider.GetAllClients();
            ProjectsList = await dbServices.DataProvider.GetAllProjects();
            AcquisitionsList = await dbServices.DataProvider.GetAllAcquisitions();

            return;
        }*/

        #endregion

        #region Methods

        #region Client

        public async Task AddClient(Client client)
        {
            Client conflictingClient = await dbServices.DataConflictValidator.GetConflictingClient(client);
            
            if (conflictingClient != null)
            {
                throw new ClientConflictException(conflictingClient, client);
            }

            await dbServices.DataCreator.CreateClient(client);
        }

        public async Task UpdateClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException();
            }

            await dbServices.DataEditor.UpdateClient(client);
        }

        public async Task RemoveClients(IEnumerable<Client> clients)
        {

            if (!clients.Any())
            {
                throw new Exception("Niciun client nu a fost selectat.");
            }

            await dbServices.DataEraser.RemoveClients(clients);
        }

        #endregion


        #region Project

        public async Task AddProject(Project project)
        {
            Project conflictingProject = await dbServices.DataConflictValidator.GetConflictingProject(project);

            if (conflictingProject != null)
            {
                throw new ProjectConflictException(conflictingProject, project);
            }

            await dbServices.DataCreator.CreateProject(project);
        }

        public async Task UpdateProject(Project project)
        {
            if (project == null)
            {
                throw new NullReferenceException();
            }

            await dbServices.DataEditor.UpdateProject(project);
        }

        public async Task RemoveProjects(IEnumerable<Project> projects)
        {

            if (!projects.Any())
            {
                throw new Exception("Niciun proiect nu a fost selectat.");
            }

            await dbServices.DataEraser.RemoveProjects(projects);
        }

        #endregion


        #region Acquisition

        public async Task AddAcquisition(Acquisition acquisition)
        {
            // Project conflictingProject = await dbServices.DataConflictValidator.GetConflictingProject(acquisition);

            if (acquisition == null)
            {
                throw new NullReferenceException();
            }

            await dbServices.DataCreator.CreateAcquisition(acquisition);
        }

        public async Task UpdateAcquisition(Acquisition acquisition)
        {
            if (acquisition == null)
            {
                throw new NullReferenceException();
            }

            await dbServices.DataEditor.UpdateAcquisition(acquisition);
        }

        public async Task RemoveAcquisitions(IEnumerable<Acquisition> acquisitions)
        {

            if (!acquisitions.Any())
            {
                throw new Exception("Nicio achizitie nu a fost selectata.");
            }

            await dbServices.DataEraser.RemoveAcquisitions(acquisitions);
        }

        #endregion

        #endregion
    }
}
