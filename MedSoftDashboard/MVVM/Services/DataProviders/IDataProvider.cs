using MedSoftDashboard.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.DataProviders
{
    public interface IDataProvider
    {
        Task<IEnumerable<Client>> GetAllClients();
        Task<IEnumerable<Project>> GetAllProjects();
        Task<IEnumerable<Acquisition>> GetAllAcquisitions();
    }
}
