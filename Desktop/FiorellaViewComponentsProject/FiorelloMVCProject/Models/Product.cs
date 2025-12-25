using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiorelloMVCProject.Models
{
    public class Product : BaseEntity

    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
