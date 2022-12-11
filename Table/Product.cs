using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class Product
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }
        public bool IsActive { get; set; }

        [MaxLength(50)]
        public string? Descripion { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

        public ICollection<BasketProduct> BasketProduct { get; set; }

      
    }
}
