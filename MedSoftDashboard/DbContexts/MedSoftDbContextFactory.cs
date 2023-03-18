using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.DbContexts
{
    public class MedSoftDbContextFactory
    {
        private string _connectionString;

        public MedSoftDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MedSoftDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString)).Options;

            return new MedSoftDbContext(options);
        }
    }
}
