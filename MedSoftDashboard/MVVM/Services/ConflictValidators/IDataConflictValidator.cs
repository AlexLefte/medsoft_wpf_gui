using MedSoftDashboard.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.ConflictValidators
{
    public interface IDataConflictValidator
    {
        Task<Client> GetConflictingClient(Client client);
        Task<Project> GetConflictingProject(Project project);
    }
}
