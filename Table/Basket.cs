using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class Basket
    {
        public Guid BasketId { get; set; }
        public string? CodNameBaket { get; set; }
        public Guid ClientId { get; set; }
        public DateTime DateCreateBk { get; set; }


        public Client CurrentClient { get; set; }   
       
        
        public List<BasketProduct> CurrentBasketProduct { get; set; }   
    }
}
