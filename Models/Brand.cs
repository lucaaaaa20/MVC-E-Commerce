using System.ComponentModel.DataAnnotations;

namespace MVCECommerce.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Variant> Variant { get; set; }
    }
}
