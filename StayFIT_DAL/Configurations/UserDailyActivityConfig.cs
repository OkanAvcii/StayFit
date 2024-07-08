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
    public class UserDailyActivityConfig : IEntityTypeConfiguration<UserDailyActivity>
    {
        public void Configure(EntityTypeBuilder<UserDailyActivity> builder)
        {

            builder.Property(x => x.Activity).IsRequired().
                HasMaxLength(10);
            builder.Property(x => x.StepCount).IsRequired()
                .HasMaxLength(6);

            builder.HasOne(x => x.User)
                    .WithMany(x => x.UserDailyActivity)
                    .HasForeignKey(x => x.UserId);
        }
    }
}

