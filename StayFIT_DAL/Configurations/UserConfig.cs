using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StayFIT_CORE.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).IsRequired()
            .HasColumnType("nvarchar")
            .HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(75);
            builder.Property(x => x.Height).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.Email).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Weight).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.Password).IsRequired()
                .HasMaxLength(20);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.Gender).IsRequired()
                .HasMaxLength(5);

        }
    }
}

