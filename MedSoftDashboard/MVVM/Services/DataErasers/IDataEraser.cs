using MedSoftDashboard.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.DataErasers
{
    public interface IDataEraser
    {
        Task RemoveClients(IEnumerable<Client> clients);
        Task RemoveProjects(IEnumerable<Project> projects);
        Task RemoveAcquisitions(IEnumerable<Acquisition> acquisition);
    }
}
