using Common.Backend.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Common.Backend.Data.EF
{
    /// <summary>
    /// Data context class
    /// </summary>
    public class DataContext : DbContext
    {
        #region "CTOR"

        public DataContext(DbContextOptions<DataContext> options)
  : base(options)
        {
        }

        #endregion

        #region "OVERRIDE METHODS"

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region "DB SETS"

        public DbSet<ProductLogEntity> ProductLogs { get; set; }
        public DbSet<VehicleProcessEntity> VehicleProcesses { get; set; }

        #endregion

    }
}
