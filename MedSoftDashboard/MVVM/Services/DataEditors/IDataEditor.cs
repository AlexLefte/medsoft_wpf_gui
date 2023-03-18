using MedSoftDashboard.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services.DataEditors
{
    public interface IDataEditor
    {
        Task UpdateClient(Client client);
        Task UpdateProject(Project project);
        Task UpdateAcquisition(Acquisition acquisition);
    }
}
