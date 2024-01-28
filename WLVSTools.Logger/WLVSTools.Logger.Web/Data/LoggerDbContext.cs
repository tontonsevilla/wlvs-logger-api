using Microsoft.EntityFrameworkCore;
using WLVSTools.Logger.Web.Data.Entity;

namespace WLVSTools.Logger.Web.Data
{
    public partial class LoggerDbContext : DbContext
    {
        public virtual DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.\\Database\\logs.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
