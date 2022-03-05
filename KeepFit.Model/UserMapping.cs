using KeepFit.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Model
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(x => x.UserId);
            Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(50);
            Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(30);
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);
            Property(x => x.Surname)
                .IsRequired()
                .HasMaxLength(30);
            Property(x => x.BirthDate)
                .IsRequired();
            Property(x => x.Weight)
                .IsRequired();
            Property(x => x.Height)
                .IsRequired();
            Property(x => x.Gender)
                .IsRequired();
            Property(x => x.LifeStyle)
                .IsRequired();
            Property(x => x.Goal)
                .IsRequired();                                


        }

    }
}
