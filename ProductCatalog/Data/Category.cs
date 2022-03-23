using System;

namespace ProductCatalog.Data
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ProductId { get; set; }
    }
}
