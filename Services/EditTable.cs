using MyFirstShop.DataBase;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Services
{
    public class EditTable
    {
        MyFirstShopContext context = new MyFirstShopContext();

       public void EditValueForClient()
        {
            // List<Client> Columns = new List<Client>(); 
            //var ValueDate = Console.ReadLine();   

            //var StateEdit = new Client() { Columns.Add(ValueDate) };
            
            var editValue = new Client() { ClientId = new Guid("306F5992-4469-4A92-B025-18797F6FCD27"),LastName = "Legros" };

            editValue.FirstName = "Moraru";
            editValue.LastName = "Igor";

            context.Update<Client>(editValue);
            context.SaveChanges();
        }


    }
}
