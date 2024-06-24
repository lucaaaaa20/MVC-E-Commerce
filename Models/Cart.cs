using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCECommerce.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid IdSession { get; set; }
        public virtual ClientData? ClientData { get; set; }
        [ForeignKey(nameof(ClientData))]
        public int? ClientDataId { get; set; }
        public ICollection<CartArticle> CartArticle { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
