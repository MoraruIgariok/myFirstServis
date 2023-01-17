using MyFirstShop.DataBase;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Services
{
    public class RemoveDate
    {
        MyFirstShopContext context = new MyFirstShopContext();
        
        public void RemoveById()
        {
            Guid IdClient = Guid.NewGuid();
            var clients = new Client() { ClientId = IdClient };


            Console.WriteLine("Indicate the Id to be deleted form Client table");
            var NewValue = Console.ReadLine();

            IdClient = Guid.Parse(NewValue); try
            {
                context.Remove<Client>(clients);
                context.SaveChanges();
            }
            catch (IOException e)
            {
                Console.WriteLine("There is not such data {0}",e);
            }
            
            
            
        }
    }
}
