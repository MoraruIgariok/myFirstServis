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
        public Guid Id { get; set; }
        
        [MaxLength(50)]
        public string First_Name { get; set; }

        [MaxLength(50)] 
        public string Last_Name { get; set; }

        [MaxLength(50)]
        public string? Phone_Number { get; set; }

        [MaxLength(50)]
        public string EmailAdress { get; set; }

        public ICollection<BasketProduct> CurremtBasketProduct { get; set; }  
    }
}
