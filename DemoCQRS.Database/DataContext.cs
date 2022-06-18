using DemoCQRS.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoCQRS.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        internal DbSet<DbPeople> Peoples { get; set; }
    }
}