using MedSoftDashboard.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Stores
{
    public class WorkspaceStore
    {
        private readonly Workspace _workspace;
        private readonly List<Client> _clients;
        private readonly List<Project> _projects;
        private readonly List<Acquisition> _acquisitions;

        private readonly Lazy<Task> _initializeLazy;

        public IEnumerable<Client> Clients => _clients;
        public IEnumerable<Project> Projects => _projects;
        public IEnumerable<Acquisition> Acquisitions => _acquisitions;


        public WorkspaceStore(Workspace ws)
        {
            _workspace = ws;
            _initializeLazy = new Lazy<Task>(Initialize);
            _clients = new List<Client>();
        }

        public async Task AddClient(Client newClient)
        {
            await _workspace.AddClient(newClient);

            _clients.Add(newClient);
        }

        public async Task RemoveClients(List<Client> clients)
        {
            await _workspace.RemoveClients(clients);

            var toBeRemoved = new HashSet<Client>(clients);
            _clients.RemoveAll(client => toBeRemoved.Contains(client));
        }

        public async Task LoadClients()
        {
            await _initializeLazy.Value;
        }

        public async Task Initialize()
        {
            IEnumerable<Client> clients = await _workspace.GetAllClients();

            _clients.Clear();
            _clients.AddRange(clients);
        }
    }
}
