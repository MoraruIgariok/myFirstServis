using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class DepositProduct
    {
        public Guid Id { get; set; } 
        public Guid ProductId { get; set; }    
        public Guid DepositId   { get; set; }

        public Product currentProduct { get; set; }
        public Deposit currentDeposit { get; set; }  
    }
}
