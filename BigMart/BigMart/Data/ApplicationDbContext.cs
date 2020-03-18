using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BigMart.Models;

namespace BigMart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BigMart.Models.InventoryModel> InventoryModel { get; set; }
        public DbSet<BigMart.Models.UserModel> UserModel { get; set; }
        public DbSet<BigMart.Models.ProductModel> ProductModel { get; set; }
    }
}
