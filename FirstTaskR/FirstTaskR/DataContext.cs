using FirstTaskR.Shared.Data.Tables;
using Microsoft.EntityFrameworkCore;
namespace FirstTaskR
{
    public class DataContext : DbContext
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<well_day_history>()
        //        .Property(p => p.ee_consume)
        //        .HasColumnType("decimal(5, 2)");
        //    modelBuilder.Entity<well_day_history>()
        //        .Property(p => p.expenses)
        //        .HasColumnType("decimal(4, 3)");
        //    //modelBuilder.Entity<well_day_history>()
        //    //    .HasKey(nameof(well_day_history.well), nameof(well_day_history.date_fact));
        //    //modelBuilder.Entity<well_day_plan>()
        //    //    .HasKey(nameof(well_day_plan.well), nameof(well_day_plan.date_plan));
        //}
        public DbSet<ObjectType> object_types { get; set; }
        public DbSet<Shared.Data.Tables.Object> objects { get; set; }
        public DbSet<Well> wells { get; set; }
        public DbSet<WellDayHistory> well_day_histories { get; set; }
        public DbSet<WellDayPlan> well_day_plans { get; set; }
        public DataContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Database.db");
        }
    }
}

