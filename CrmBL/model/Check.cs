using System;
using System.Collections.Generic;

namespace CrmBL.model
{
    public class Check
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Status Status { get; set; }

        
        //public virtual List<Product> Sells { get; set; }
    }

    public enum Status
    {
        Sells, // Продано
        WriteOff, // Списано
        Return // Повернено
    }
}