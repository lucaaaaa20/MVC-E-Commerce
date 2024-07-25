using System.ComponentModel.DataAnnotations;

namespace MVCECommerce.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Category> Category { get; set; }
        public ICollection<Article> Article { get; set; }
    }
}
