using Azure;
using MyFirstShop.Services;
using System;
using System.Net.Sockets;

namespace MyFirstShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientService obj = new();

            var responsEdit = obj.EditClient(new ClientEditRequest
            {
                FirstName = "Moraru"
                
            });
            Console.WriteLine(responsEdit.GetEditValue());


            //    ClientService obj = new();
            //    Console.WriteLine("Write info for Client(FirstName/LastName/EmailAdress/PhoneNumber)\n");
            //    var respons = obj.AddClient(new ClientAddRequest
            //    {
            //        FirstName = Console.ReadLine(),
            //        LastName = Console.ReadLine(),
            //        EmailAdress = Console.ReadLine(),
            //        PhoneNumber = Console.ReadLine()
            //    });

            //    Console.WriteLine(respons.GetFullName());
        }
    }
}