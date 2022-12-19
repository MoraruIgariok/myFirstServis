using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class BasketProduct
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string ShopeName { get; set; }

        public int Count { get; set; }

        public DateTime CreatedDate { get; set; }   

        public Guid ClientId { get; set; }  
        public Client CurrentClient{ get; set; }

        public Guid ProductId { get; set; } 
        public Product CurrentProduct{ get; set; }

    }
}
