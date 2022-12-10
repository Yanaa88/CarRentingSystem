using System.ComponentModel.DataAnnotations;

namespace CarRentingSystem.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Cars = new List<Car>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public List<Car> Cars { get; set; }
    }
}
