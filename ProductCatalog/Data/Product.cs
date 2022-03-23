using System;

namespace ProductCatalog.Data
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Displayname { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool Active { get; set; }
        public Brand Brand { get; set; }
        public ProductPrice Price { get; set; }
        public Category Category { get; set; }
        public Guid BrandId { get; set; }
    }
}
