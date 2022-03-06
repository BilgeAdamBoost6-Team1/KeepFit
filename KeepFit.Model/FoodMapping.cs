using KeepFit.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Model
{
    public class FoodMapping : EntityTypeConfiguration<Food>
    {
        public FoodMapping()
        {
            HasKey(x => x.FoodId);
            Property(x => x.FoodName)
                .IsRequired()
                .HasMaxLength(50);
            Property(x => x.Calorie)
                .IsRequired()
                .HasPrecision(7, 2);
            Property(x => x.Protein)
                .IsRequired()
                .HasPrecision(7, 2);
            Property(x => x.Carbohydrate)
                .IsRequired()
                .HasPrecision(7, 2);
            Property(x => x.Fat)
                .IsRequired()
                .HasPrecision(7, 2);
            Property(x => x.FoodType)
                .IsRequired();
            Property(x => x.Gram)
                .IsRequired()
                .HasPrecision(7, 2);

        }
    }
}
