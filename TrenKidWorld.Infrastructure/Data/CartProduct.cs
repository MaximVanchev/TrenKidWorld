using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrenKidWorld.Infrastructure.Data.Constants;
using TrenKidWorld.Infrastructure.Data.Identity;

namespace TrenKidWorld.Infrastructure.Data
{
    public class CartProduct
    {
        public CartProduct()
        {
            Id = Guid.NewGuid();
            InCart = true;
            ProductConut = 1;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public TrenKidWorldUser User { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        [Required]
        [Range(DatabaseConstants.Products_Count_Min_Length, DatabaseConstants.Products_Count_Max_Length)]
        public int ProductConut { get; set; }

        [Required]
        public bool InCart { get; set; }
    }
}
