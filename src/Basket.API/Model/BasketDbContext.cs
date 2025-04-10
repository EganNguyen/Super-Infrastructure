using System.Collections.Generic;
using eShop.Basket.API.Model;
using Microsoft.EntityFrameworkCore;
using BasketItem = eShop.Basket.API.Model.BasketItem;

namespace Basket.API
{
    public class BasketDbContext : DbContext
    {
        public BasketDbContext(DbContextOptions<BasketDbContext> options) : base(options) { }

        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<CustomerBasket> CustomerBaskets { get; set; }
    }
}
