using System.ComponentModel.DataAnnotations;
using TrenKidWorld.Infrastructure.Data.Constants;

namespace TrenKidWorld.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(DatabaseConstants.Category_Name_Max_Length)]
        public string Name { get; set; }

        public IList<Product> Products { get; set; }
    }
}