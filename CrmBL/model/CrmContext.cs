using System.Data.Entity;

namespace CrmBL.model
{
    public class CrmContext:DbContext
    {
        public DbSet<Check> Checks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells { get; set; }
            
        
        public CrmContext() : base("ToyShopCrm") { }
        
        
    }
}