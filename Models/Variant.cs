using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MVCECommerce.Models
{
    public class Variant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Stock {  get; set; }

        [Required]
        public double Price { get; set; }

        public string? LinkImg { get; set; }

        [Required]
        public virtual Article Article { get; set; }
        [ForeignKey(nameof(Article))]
        [Required]
        public int ArticleId { get; set; }

        public virtual Size? Size { get; set; }
        [ForeignKey(nameof(Size))]
        [AllowNull]
        public int? SizeId { get; set; }

        public virtual Color? Color { get; set; }
        [ForeignKey(nameof(Color))]
        [AllowNull]
        public int? ColorId { get; set; }

        public virtual Brand? Brand { get; set; }
        [ForeignKey(nameof(Brand))]
        [AllowNull]
        public int? BrandId { get; set; }

        public ICollection<CartArticle> CartArticle { get; set; }
    }
}
