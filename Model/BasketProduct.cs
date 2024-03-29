﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class BasketProduct
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; } 
        public Guid BasketId { get; set; }

        [Precision(13,2)]
        public decimal Count { get; set; }
       

        //connection
        public Product products { get; set; }
        public Basket baskets { get; set; }


    }
}
