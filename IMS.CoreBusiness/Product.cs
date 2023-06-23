using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        
        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater or equal to zero")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater or equal to zero")]
        public double Price { get; set; }

    }
}
