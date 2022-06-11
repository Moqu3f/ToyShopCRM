using System.Collections.Generic;

namespace CrmBL.model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        
        public virtual ICollection<Sell> Sells { get; set; }
    }
}