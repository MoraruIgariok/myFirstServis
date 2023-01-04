using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class Deposit
    {
        public Guid Id { get; set; }

        [MaxLength(30)]
        public string Categori { get; set; }

        [Precision(13,2)]
        public decimal CoutProduct { get; set; }  
        
        public DateTime DateImport { get; set; }   


   

        public  List<DepositShop> depositShopList { get; set; } 
           

    }
}
