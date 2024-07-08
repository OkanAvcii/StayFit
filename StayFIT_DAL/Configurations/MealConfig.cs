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
    public class MealConfig : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            {
                builder.Property(x => x.Name).IsRequired()
                    .HasColumnType("nvarchar")
                    .HasMaxLength(200);

                builder.HasOne(x => x.UserDailyActivity).WithMany(x => x.Meals).HasForeignKey(x => x.UserDailyActivityId);
            }
        }
    }
}
