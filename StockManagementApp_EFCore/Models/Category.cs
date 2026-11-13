using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? ParentCategoryId { get; set; }

    public string? Path { get; set; }

    public byte Level { get; set; }

    public virtual ICollection<Category> InverseParentCategory { get; set; } = new List<Category>();

    public virtual Category? ParentCategory { get; set; }

    public virtual ICollection<Product> Product { get; set; } = new List<Product>();
}
