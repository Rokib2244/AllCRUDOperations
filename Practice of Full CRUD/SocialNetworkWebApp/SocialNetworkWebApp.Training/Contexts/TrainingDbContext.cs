using Microsoft.EntityFrameworkCore;
using SocialNetworkWebApp.Training.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkWebApp.Training.Contexts
{
    public class TrainingDbContext : DbContext, ITrainingDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        public TrainingDbContext( string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if(!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }
        }
        //protected override void OnModelCreating()
        //{

        //}
        public DbSet<Member> Members { get; set; }

    }
}
