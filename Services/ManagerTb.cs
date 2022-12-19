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
                    Name = new Faker().Commerce.ProductName(),
                    Descripion = new Faker().Company.CompanyName(),
                    IsActive = new bool(),
                    Quantity = new int(),
                    Price = new decimal(),
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
                    ShopeName = new Faker().Company.CompanyName(),
                    Count = new Random().Next(50),
                    CreatedDate = new Faker().Person.DateOfBirth,
                    ClientId = new Client().Id,
                    ProductId = new Product().Id
                });
                
                context.SaveChanges();
                i++;
            }
        } 


    }
}
