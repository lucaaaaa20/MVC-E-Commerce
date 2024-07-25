using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCECommerce.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? LinkImg { get; set; }

        public virtual Group? Group { get; set; }
        [ForeignKey(nameof(Group))]
        public int? GroupId { get; set; }

        public virtual Category? Category { get; set; }
        [ForeignKey(nameof(Category))]
        public int? CategoryId { get; set; }

        public ICollection<Variant> Variant { get; set; }
    }
}
