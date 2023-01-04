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

                    ClientId = Guid.NewGuid(),
                    FirstName = new Faker().Person.FirstName,
                    LastName = new Faker().Person.LastName,
                    PhoneNumber = new Faker().Person.Phone,
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
                    ProductId = Guid.NewGuid(),
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
       
       


    }
}
