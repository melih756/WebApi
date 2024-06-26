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
    internal class ProductSeed: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product{ Id=1,CategoryId=1,Name="Kalem",Price=100,Stock=50,CreatedDate=DateTime.Now},
                new Product { Id = 2, CategoryId = 1, Name = "Kalem2", Price = 150, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 2, Name = "Kitap", Price = 137, Stock = 52, CreatedDate = DateTime.Now });
        }
    }
}
