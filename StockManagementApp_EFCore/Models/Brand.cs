using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Country { get; set; }

    public virtual ICollection<Product> Product { get; set; } = new List<Product>();
}
