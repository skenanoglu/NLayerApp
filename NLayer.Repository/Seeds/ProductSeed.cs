﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product { Id = 1, CategoryId = 1,Name="Kalem 1",Price = 100, Stock = 32, CreatedDate = DateTime.Now });
            builder.HasData(new Product { Id = 2, CategoryId = 1, Name = "Kalem 2", Price = 234, Stock = 2, CreatedDate = DateTime.Now });
            builder.HasData(new Product { Id = 3, CategoryId = 3, Name = "Defter 1", Price = 654, Stock = 44, CreatedDate = DateTime.Now });
            builder.HasData(new Product { Id = 4, CategoryId = 2, Name = "Kitap 1", Price = 123, Stock = 55, CreatedDate = DateTime.Now });
        }
    }
}
