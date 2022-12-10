using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Infrastructure.Data.Configuration
{
    internal class EquipmentConfiguration :IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasData(CreateEquipment());
        }


        private List<Equipment> CreateEquipment()
        {
            List<Equipment> equipmentList = new List<Equipment>()
            {
                new Equipment()
                {
                    Id = 1,
                    Name = "Air-Conditioner",
                },
                new Equipment()
                {
                    Id = 2,
                    Name = "Automatic Gearbox"
                },
                new Equipment()
                {
                    Id = 3,
                    Name = "Manual Gearbox"
                },
                new Equipment()
                {
                    Id = 4,
                    Name = "Diesel"
                }
            };

            return equipmentList;
        }
    }
}
