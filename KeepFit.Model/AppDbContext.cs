using KeepFit.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Model
{
    public class AppDbContext :DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=KeepFitDB;Trusted_Connection=True;";
        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Meal> Meal { get; set; }
        public virtual DbSet<MealsFoods> MealsFoods{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FoodMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new MealMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
