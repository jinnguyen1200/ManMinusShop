using System;
using System.Collections.Generic;
using System.Text;
using ManMinusData.Entities.Business;
using Microsoft.EntityFrameworkCore;

namespace ManMinusData.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasData(
            //    new Category() { Id = 1, Name = "Flannel", Description = "Ao Flannel" },
            //    new Category() { Id = 2, Name = "Ao khoac", Description = "Ao khoac gio" });
        }
    }
}
