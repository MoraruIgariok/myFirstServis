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
            Client clientEntity = new Client
            {
                 EmailAdress = client.EmailAdress,
                 LastName = client.LastName,
                 FirstName = client.FirstName,  
                 PhoneNumber = client.PhoneNumber,  
            };
            var Response = context.Add<Client>(clientEntity);
            context.SaveChanges();  
            return new ClientAddResponse
            {
                FirstName = clientEntity.FirstName,
                LastName = clientEntity.LastName,    
            };
        }

        public ClientEditResponse EditClient(ClientEditRequest client)
        {
            Client firstClient = context.Clients.First();
            Console.WriteLine("value for update is ", firstClient.LastName);
            //if(firstClient != null)
            //{
            //    firstClient.LastName = client.LastName;
            //    firstClient.PhoneNumber = client.PhoneNumber;
            //    firstClient.EmailAdress = client.EmailAdress;
            //    context.SaveChanges();
            //}


            return new ClientEditResponse
            {
                EmailAdress = firstClient.EmailAdress,
                FirstName = firstClient.FirstName,
                LastName = firstClient.LastName,
                PhoneNumber = firstClient.PhoneNumber
            };

        }

        public ClientGetResponse GetClient(ClientGetRequest client)
        {
            throw new NotImplementedException();
        }

        public Client GetClientById(ClientGetByIdRequest client)
        {
            throw new NotImplementedException();
        }

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
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public string GetFullName() 
        {
           return $"Clientu {FirstName} {LastName} a fost adaugat";
            
        }
        
        

    }

    public class ClientEditRequest
    {
        public Guid Id { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAdress { get; set; }
    }

    public class ClientEditResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }

        public string GetEditValue()
        {
            return $"New value is {FirstName} {LastName} has Phone - {PhoneNumber} and  email - {EmailAdress} ";
        }
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
