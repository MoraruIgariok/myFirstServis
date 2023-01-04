using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class Shop
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string ShopName { get; set; }

        [MaxLength(100)]
        public string AdressShop { get; set; }

        [MaxLength(20)]
        public string PhoneNumberShop { get; set; }

                
        public List<DepositShop> depositShopList { get; set; }   

    }
}
