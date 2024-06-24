using System.ComponentModel.DataAnnotations;

namespace MVCECommerce.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(6)]
        public int HexColor {  get; set; }
        public ICollection<Variant> Variant { get; set; }
    }
}
