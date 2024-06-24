using System.ComponentModel.DataAnnotations;

namespace MVCECommerce.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string LinkImg { get; set; }
        public ICollection<Variant> Variant { get; set; }
    }
}
