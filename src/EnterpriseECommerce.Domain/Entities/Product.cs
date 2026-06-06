using EnterpriseECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseECommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
