using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace MedSoftDashboard.DbContexts
{
    public class MedSoftDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MedSoftDbContext>
    {
        public MedSoftDbContext CreateDbContext(string[] args)
        {
            string connectionString = "server=localhost;database=medsoftdb;user=MedSoftUser;password=af@345SDE456$$%%dgt";
            DbContextOptions options = new DbContextOptionsBuilder().UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)).Options;

            return new MedSoftDbContext(options);
        }
    }
}
