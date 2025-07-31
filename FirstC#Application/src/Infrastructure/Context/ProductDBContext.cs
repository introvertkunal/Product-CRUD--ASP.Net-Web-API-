using FirstC_Application.src.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace FirstC_Application.src.Infrastructure.Context
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
