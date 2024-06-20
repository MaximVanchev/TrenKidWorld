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
    public class Product
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(DatabaseConstants.Category_Name_Max_Length , MinimumLength = DatabaseConstants.Name_Min_Length)]
        public string Name { get; set; }

        [Required]
        [StringLength(DatabaseConstants.Description_Max_Length)]
        public string Description { get; set; }

        [Required]
        public byte[] Image { get; set; }

        [Required]
        [Range(DatabaseConstants.Price_Min_Range, DatabaseConstants.Price_Max_Pange)]
        [DataType("decimal(19,4)")]
        public Decimal Price { get; set; }

        public IList<TrenKidWorldUser> UsersLiked { get; set; } = new List<TrenKidWorldUser>();

        public IList<CartProduct> CartProducts { get; set; } = new List<CartProduct>();

        public IList<Option> Options { get; set; } = new List<Option>();

        [Required]
        [StringLength(DatabaseConstants.Guid_Max_Length)]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
