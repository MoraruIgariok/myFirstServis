 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string? Phone_Number { get; set; }
        public string EmailAdress { get; set; }

        public Basket CurrentBasket { get; set; }  
    }
}
