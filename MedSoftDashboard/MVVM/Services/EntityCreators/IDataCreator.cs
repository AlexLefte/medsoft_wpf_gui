using MedSoftDashboard.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.EntityCreators
{
    public interface IDataCreator
    {
        Task CreateClient(Client client);
        Task CreateProject(Project project);
        Task CreateAcquisition(Acquisition acquisition);
    }
}
