using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ProductAttribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DataType { get; set; } = null!;

    public virtual ICollection<ProductAttributeValue> ProductAttributeValue { get; set; } = new List<ProductAttributeValue>();
}
