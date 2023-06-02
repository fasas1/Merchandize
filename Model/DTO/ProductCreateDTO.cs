using System.ComponentModel.DataAnnotations;

namespace Merchantdized.Model.DTO
{
    public class ProductCreateDTO
    {
      
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Category { get; set; }
        [Range(1, int.MaxValue)]
        public double Price { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
