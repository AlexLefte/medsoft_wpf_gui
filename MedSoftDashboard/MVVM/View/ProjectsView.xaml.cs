using MedSoftDashboard.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedSoftDashboard.MVVM.View
{
    /// <summary>
    /// Interaction logic for ProjectsView.xaml
    /// </summary>
    public partial class ProjectsView : UserControl
    {
        public ProjectsView()
        {
            InitializeComponent();
        }

        private void ProjectsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var projectsVM = (ProjectsViewModel)DataContext;

            if (projectsVM != null)
            {
                projectsVM.SelectedProjects = projectsList.SelectedItems.Cast<ProjectViewModel>().ToList();

                if (projectsList.SelectedItems?.Count != 1)
                {
                    projectsVM.EditedProject = null;
                    editButton.IsEnabled = false;
                    editButton.Background = Brushes.LightGray;
                }
                else
                {
                    projectsVM.EditedProject = ((ProjectViewModel)projectsList.SelectedItem).Project;
                    editButton.IsEnabled = true;
                    editButton.Background = Brushes.Green;
                }

                if (projectsList.SelectedItems?.Count == 0)
                {
                    deleteButton.IsEnabled = false;
                    deleteButton.Background = Brushes.LightGray;
                }
                else
                {
                    deleteButton.IsEnabled = true;
                    deleteButton.Background = Brushes.Red;
                }
            }
        }
    }
}
