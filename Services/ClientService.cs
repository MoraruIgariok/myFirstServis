using Bogus;
using MyFirstShop.DataBase;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Services
{
    public class ClientService : IClientService
    {
        MyFirstShopContext context =new MyFirstShopContext();
        public ClientAddResponse AddClient(ClientAddRequest client)
        {
            context.Clients.Add(new Table.Client
            {

                ClientId = Guid.NewGuid(),
                FirstName = new Faker().Person.FirstName,
                LastName = new Faker().Person.LastName,
                PhoneNumber = new Faker().Person.Phone,
                EmailAdress = new Faker().Person.Email

            });
            context.SaveChanges();

            return;
        }

       public ClientEditResponse EditClient(ClientEditRequest client)
        {
            var editValue = new Client() { 
                ClientId = new Guid("306F5992-4469-4A92-B025-18797F6FCD27"), 
                LastName = "Legros" 
            };

            editValue.FirstName = "Moraru";
            editValue.LastName = "Igor";

            context.Update<Client>(editValue);
            context.SaveChanges();
            return editValue;
        }

        public ClientGetResponse GetClient(ClientGetRequest client)
        {
            var clients = context.Clients;
            foreach (Client c in clients)
            {
                Console.WriteLine("Last name: " + c.LastName + " \nFirst name: " + c.FirstName + "\nPhone Number: " + c.PhoneNumber + "\nAdress name: " + c.EmailAdress);
            }
            return clients;
        }

        public Client GetClientById(ClientGetByIdRequest client)
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
                Console.WriteLine("There is not such data {0}", e);
            }
            return clients;
        }
    }

    public interface IClientService
    {
        public ClientAddResponse AddClient(ClientAddRequest client);
        public ClientEditResponse EditClient(ClientEditRequest client);
        public ClientGetResponse GetClient(ClientGetRequest client);
        public Client GetClientById(ClientGetByIdRequest client);
    }


    public class ClientAddRequest
    {
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string? PhoneNumber { get; set; }

        [MaxLength(100)]
        public string EmailAdress { get; set; }

    }

    public class ClientAddResponse
    {
        public Guid ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string EmailAdress { get; set; }

    }

    public class ClientEditRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAdress { get; set; }
    }

    public class ClientEditResponse
    {
    }

    public class ClientGetRequest
    {
       public string Search {get;set;}  
    }

    public class ClientGetResponse
    {
       public List<Client> Clients { get; set; } 
    }

    public class ClientGetByIdRequest
    {
       public Guid Id { get; set; }    
    }

  
 
}
