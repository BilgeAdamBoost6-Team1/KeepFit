using KeepFit.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Model
{
    public class MealMapping : EntityTypeConfiguration<Meal>
    {
        public MealMapping()
        {
            HasKey(x => x.MealId);
            Property(x => x.MealName)
                .IsRequired()
                .HasMaxLength(50);
            Property(x => x.MealType)
                .IsRequired();
            Property(x => x.CreateTime)
                .IsRequired();       

        }

    }
}
