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
        public Guid ProductId { get; set; } 
        public Guid BasketId { get; set; }  
        public decimal Count { get; set; }
           //connection
        public List<Product> products { get; set; }
        public List<Basket> baskets { get; set; }


    }
}
