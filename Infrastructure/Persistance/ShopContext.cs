using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        public DbSet<BlogEntity> Blogs { get; set; }
        public DbSet<BlogCategoryEntity> BlogCategories { get; set; }
        public DbSet<CategoryProductEntity> CategoryProducts { get; set; }
        public DbSet<ProductEntity> products { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<SliderEntity> Sliders { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
