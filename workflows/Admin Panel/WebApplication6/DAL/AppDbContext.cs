﻿using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category>Categories { get; set; }  
        public DbSet<Product>Products { get; set; }
        public DbSet<Tag>Tags { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }    
    }
}
