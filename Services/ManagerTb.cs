using MyFirstShop.DataBase;

using System;
using Bogus;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using Bogus.Extensions;
using MyFirstShop.Table;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace MyFirstShop.Services
{
    public class ManagerTb
    {
        MyFirstShopContext context = new MyFirstShopContext();
        private bool[] T =new bool[] {true,false};
       
        public void AddClient()
        {
            for (int i = 0; i < 20; i++)
            {
                context.Clients.Add(new Table.Client
                {

                    Id = Guid.NewGuid(),
                    First_Name = new Faker().Person.FirstName,
                    Last_Name = new Faker().Person.LastName,
                    Phone_Number = new Faker().Person.Phone,
                    EmailAdress = new Faker().Person.Email

                });
                context.SaveChanges();
                i++;
            }
        }
       public void AddProduct()
        {
            for (int i = 0; i < 20; i++)
            {
                context.Products.Add(new Table.Product
                {
                    Id = Guid.NewGuid(),
                    Name = new Faker().Person.ToString(),
                    Descripion = new Faker().Person.ToString(),
                    IsActive = new Faker().PickRandom(T),
                    Quantity = new Faker().Person.FirstName.Length,
                    Price = new Faker().Person.LastName.Length / 5,
                });
                context.SaveChanges();
                i++;
            }
        }
        public void AddBaketProduct()
        {
            for (int i = 0; i < 3; i++)
            {
                context.BasketProducts.Add(new Table.BasketProduct
                {
                    Id = Guid.NewGuid(),
                    ShopeName = new Faker().Person.Company.Name.TrimEnd(),
                    Count = new Faker().Person.LastName.Length,
                    CreatedDate = new Faker().Person.DateOfBirth,
                    Client = new Client(),
                    Product = new Product()
                });
                context.SaveChanges();
                i++;
            }
        } 


    }
}
