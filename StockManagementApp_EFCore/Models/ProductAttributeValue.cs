using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ProductAttributeValue
{
    public int Id { get; set; }

    public int ProductAttributeId { get; set; }

    public string Value { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ProductAttribute ProductAttribute { get; set; } = null!;

    public virtual ICollection<ProductVariant> ProductVariant { get; set; } = new List<ProductVariant>();
}
