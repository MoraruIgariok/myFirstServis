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
                Console.WriteLine("Last name: "+c.Last_Name + " \nFirst name: " + c.First_Name + "\nPhone Number: " + c.Phone_Number + "\nAdress name: " + c.EmailAdress);
            }
            
        }
    }
}
