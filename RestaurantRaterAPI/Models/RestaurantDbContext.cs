using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace RestaurantRaterAPI.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("DefaultConnection") { }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}