using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class DepositShop
    {
        public Guid Id { get; set; }  
        
        public Guid DepositId { get; set; } 
        
        public Guid ShopId { get; set; }

        public DateTime OrderDate { get; set; }    

        public Shop shop { get; set; }
        public Deposit deposit { get; set; }    

    }
}
