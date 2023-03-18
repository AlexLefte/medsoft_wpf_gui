using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.Model;

namespace MedSoftDashboard.MVVM.Exceptions
{
    public class ProjectConflictException : Exception
    {
        public Project ExistingProject { get; }

        public Project ConflictingProject { get; }

        public ProjectConflictException(Project existingProject, Project conflictingProject)
        {
            ExistingProject = existingProject;
            ConflictingProject = conflictingProject;
        }

        public ProjectConflictException(string message, Project existingProject, Project conflictingProject) : base(message)
        {
            ExistingProject = existingProject;
            ConflictingProject = conflictingProject;
        }

        public ProjectConflictException(string message, Exception innerException, Project existingProject, Project conflictingProject) : base(message, innerException)
        {
            ExistingProject = existingProject;
            ConflictingProject = conflictingProject;
        }

        protected ProjectConflictException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
