﻿namespace WebApplication6.Models
{
    public class ProductPhoto
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }    
    }
}