using System;

namespace ProductCatalog.Data
{
    public class ProductPrice
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public double Price { get; set; }
    }
}
