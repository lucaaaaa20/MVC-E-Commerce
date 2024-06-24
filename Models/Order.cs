using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MVCECommerce.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Cart? Cart { get; set; }
        [ForeignKey(nameof(Cart))]
        [AllowNull]
        public int CartId { get; set; }

        [Required]
        public virtual OrderStatus? OrderStatus { get; set; }
        [ForeignKey(nameof(OrderStatus))]
        [AllowNull]
        public int OrderStatusId { get; set; }

        [Required]
        public virtual DeliveryStatus? DeliveryStatus { get; set; }
        [ForeignKey(nameof(DeliveryStatus))]
        [AllowNull]
        public int DeliveryStatusId { get; set; }

    }
}
