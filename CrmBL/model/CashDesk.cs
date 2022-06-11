using System;
using System.Collections.Generic;
using System.Linq;

namespace CrmBL.model
{
    public class CashDesk
    {
        CrmContext db;
        
        public Cart Cart { get; set; }
        public bool IsModel { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }


        public CashDesk(CrmContext db)
        {
            //Cart = new Cart();
            IsModel = true;
            this.db = db ?? new CrmContext();
        }


        public void AddCard(Cart Cart)
        {
            this.Cart = Cart;
        }


        public double ReturnProduct(Check check)
        {
            double sum = 0;
            
            var result = from sell in db.Sells
                join p in db.Products on sell.ProductId equals p.Id
                join c in db.Checks on sell.CheckId equals c.Id
                where
                    c.Id == check.Id
                select new
                {
                    p
                };
            var card = new Cart();
            foreach (var item in result)
            {
                card.Add(item.p);
            }

            Count = card.Products.Values.Sum();
            if (card != null)
            {
                check.Status = Status.Return;
                var sells = new List<Sell>();

                foreach (Product product in card)
                {
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckId = check.Id,
                            Check = check,
                            ProductId = product.Id,
                            Product = product
                        };

                        sells.Add(sell);

                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }
                            
                        product.Count++; 
                        sum += product.Price;
                        
                    }
                }
                db.SaveChanges();
            }

            db.SaveChanges();
            return sum;
        }

        public double Sell(Status status)
        {
            double sum = 0;

            var card = Cart;

            Count = card.Products.Values.Sum();
            Price = card.Price;

            if (card != null)
            {
                var check = new Check()
                {
                    Created = DateTime.Now,
                    Status = status,
                    Count = card.Products.Values.Sum(),
                    Price = card.Price

                };

                if(!IsModel)
                {
                    db.Checks.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.Id = 0;
                }

                var sells = new List<Sell>();

                foreach(Product product in card)
                {
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckId = check.Id,
                            Check = check,
                            ProductId = product.Id,
                            Product = product
                        };

                        sells.Add(sell);

                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }
                        
                        product.Count--;
                       sum += product.Price;
                        
                    }
                }

                check.Price = sum;
                if(!IsModel)
                {
                    db.SaveChanges();
                }
            }

            return sum;
        }
        
        
    }
}