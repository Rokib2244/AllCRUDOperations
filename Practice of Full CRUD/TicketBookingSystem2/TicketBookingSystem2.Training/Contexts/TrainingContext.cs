using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem2.Training.Entities;

namespace TicketBookingSystem2.Training.Contexts
{
    public class TrainingContext : DbContext, ITrainingContext
    {
        private readonly string _connectionStringName;
        private readonly string _migrationAssemblyName;
        public TrainingContext( string connectionStringName, string migrationAssemblyName)
        {
            _connectionStringName = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if(!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionStringName,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }
        }
        public DbSet<Customer> Customers { get; set; }


    }
}
