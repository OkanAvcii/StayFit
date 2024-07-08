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
    public class FoodMealConfig : IEntityTypeConfiguration<FoodMeal>
    {
        public void Configure(EntityTypeBuilder<FoodMeal> builder)
        {
            {
                builder.HasKey(x => new { x.MealId, x.FoodId });

                builder.HasOne(x => x.Meal).WithMany(x => x.FoodMeals).HasForeignKey(x => x.MealId).OnDelete(DeleteBehavior.Restrict);
                builder.HasOne(x => x.Food).WithMany(x => x.FoodMeals).HasForeignKey(x => x.FoodId).OnDelete(DeleteBehavior.Restrict);

            }
        }
    }
}
