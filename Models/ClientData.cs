using System.ComponentModel.DataAnnotations;

namespace MVCECommerce.Models
{
    public class ClientData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(13)]
        public int Phone { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public ICollection<Cart> Cart { get; set; }
    }
}
