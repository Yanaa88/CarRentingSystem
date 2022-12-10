using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Economy"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Compact"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Full Size"
                },

                 new Category()
                {
                    Id = 4,
                    Name = "Estate"
                 },

                     new Category()
                {
                    Id = 5,
                    Name = "Minivan"
                },

                      new Category()
                {
                    Id = 6,
                    Name = "SUV"
                },

                       new Category()
                {
                    Id = 7,
                    Name = "Luxury"
                },

                        new Category()
                {
                    Id = 8,
                    Name = "Electric"
                }

             };

            return categories;
        }
    }
}
