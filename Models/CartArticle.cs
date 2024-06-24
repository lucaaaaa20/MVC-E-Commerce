using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCECommerce.Models
{
    public class CartArticle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Cart Cart { get; set; }
        [ForeignKey(nameof(Cart))]
        public int CartId { get; set; }

        [Required]
        public virtual Variant Variant { get; set; }
        [ForeignKey(nameof(Variant))]
        public int VariantId { get; set; }
    }
}
