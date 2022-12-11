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

        public Client Client{ get; set; }
        public Product Product{ get; set; }


    }
}
