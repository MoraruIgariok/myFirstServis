using MyFirstShop.DataBase;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Services
{
    public class ViewesInfo
    {
        MyFirstShopContext context = new MyFirstShopContext();
        
        public void ViewClient()
        {
           var clients = context.Clients;
            foreach(Client c in clients)
            {
                Console.WriteLine("Last name: "+c.LastName + " \nFirst name: " + c.FirstName + "\nPhone Number: " + c.PhoneNumber + "\nAdress name: " + c.EmailAdress);
            }
            
        }
    }
}
