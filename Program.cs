using MyFirstShop.Services;
using System.Net.Sockets;

namespace MyFirstShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ClientService myService = new ClientService();

            int numberSolution = 0; 
            

            Console.WriteLine("Hello, What do you want to do?");
            Console.WriteLine("1.Add Value.\n2.Edit Value.\n3.View Value.\n4.Remove Value.");

            numberSolution = Convert.ToInt32(Console.ReadLine());

           /* switch (numberSolution)
            {
                case 1:myService.AddClient();
                    break;
                case 2:myService.EditClient();
                    break;
                case 3: VieweObject.ViewClient();
                    break;
                case 4: removeDate.RemoveById();
                    break;
            }
           */
         
        }
    }
}