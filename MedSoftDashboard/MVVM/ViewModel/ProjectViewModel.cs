using MedSoftDashboard.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.ViewModel
{
    public class ProjectViewModel : ViewModelBase
    {
        #region Fields

        private readonly Project _project;
        private bool _isSelected;

        #endregion

        #region Properties
        public string Id => _project.Id;
        public string Nume => _project.Nume;
        public string Tip => _project.Tip;
        public string Descriere => _project.Descriere;
        public DateTime DataFinalizare => _project.DataFinalizare;
        public DateTime DataActualizare => _project.DataActualizare;
        public string Versiune => _project.Versiune;

        public Project Project => _project;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
        #endregion


        #region Constructors

        public ProjectViewModel(Project project)
        {
            _project = project;
        }

        #endregion
    }
}
