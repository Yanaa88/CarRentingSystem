using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CarRentingSystem.Infrastructure.Data.Configuration
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(CreateCars());
        }

        private static List<Car> CreateCars()
        {
            var cars = new List<Car>()
            {
                new Car()
                 {
                      Id = 1,
                      Make = "Hyunday",
                      Model = "i20",
                      Address = "Plovdiv, Bulgaria",
                      Specifications = "5 Seats; 1 Big suitcase 70x47x36 cm; 1 Small suitcase 50x37x23 cm; 5 Doors; Manual; " +
                                       "A/C; Minimum driving age: 21",
                      ImageUrl = "https://i.dir-i.net/CMS/2020/02/19/d/5e_dct015.jpg",
                      PricePerDay= 16.00M,
                      CategoryId = 1,
                      EquipmentId = 3,                      
                      AgentId = 1,
                      RenterId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                 },

                new Car()
                {
                    Id = 2,
                    Make = "VW",
                    Model = "Passat",
                    Address = "Burgas, Bulgaria",
                    Specifications = "5 Seats; 3 Big suitcase 70x47x36 cm; 2 Small suitcase 50x37x23 cm; 5 Doors; Automatic; " +
                                       "A/C; Minimum driving age: 23",
                    ImageUrl = "https://frankfurt.apollo.olxcdn.com/v1/files/dok2kbkxf3qi2-BG/image",
                    PricePerDay = 32.00M,
                     CategoryId = 4,
                    EquipmentId = 2,                   
                    AgentId = 1
                },

                new Car()
                {
                    Id = 3,
                    Make = "Citroen",
                    Model = "C3",
                    Address = "Sofia, Bulgaria",
                    Specifications = "5 Seats; 1 Big suitcase 70x47x36 cm; 2 Small suitcase 50x37x23 cm; 5 Doors; Manual; " +
                                       "A/C; Minimum driving age: 21",
                    ImageUrl = "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg",
                    PricePerDay = 22.00M,
                    CategoryId = 2,
                    EquipmentId = 3,                   
                    AgentId = 1
                }
            };

            return cars;
        }
    }
}
