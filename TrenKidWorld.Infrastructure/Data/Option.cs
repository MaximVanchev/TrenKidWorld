using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrenKidWorld.Infrastructure.Data.Constants;

namespace TrenKidWorld.Infrastructure.Data
{
    public class Option
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        [StringLength(DatabaseConstants.Option_Name_Max_Length , MinimumLength = DatabaseConstants.Name_Min_Length)]
        public string Name { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
