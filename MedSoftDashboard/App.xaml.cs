using System.Windows;
using MedSoftDashboard.MVVM.ViewModel;
using MedSoftDashboard.MVVM.Model;
using MedSoftDashboard.MVVM.Stores;
using MedSoftDashboard.MVVM.Services;
using Microsoft.EntityFrameworkCore;
using MedSoftDashboard.DbContexts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace MedSoftDashboard
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {
                string connectionString = hostContext.Configuration.GetConnectionString("Default");
            
                services.AddSingleton(new MedSoftDbContextFactory(connectionString));
                services.AddSingleton((s) => new DatabaseServices(s.GetRequiredService<MedSoftDbContextFactory>()));
                services.AddTransient<Workspace>();
                services.AddSingleton<NavigationStore>();

                services.AddSingleton<MainViewModel>();
                services.AddSingleton(s => new MainWindow()
                {
                    DataContext = s.GetRequiredService<MainViewModel>()
                });
            }).Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start(); 

            NavigationStore navigationStore = _host.Services.GetRequiredService<NavigationStore>();
            navigationStore.CurrentViewModel = new HomeViewModel(_host.Services.GetRequiredService<Workspace>());
            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
