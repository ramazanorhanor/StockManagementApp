using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ProductLifecycle
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string Stage { get; set; } = null!;

    public DateTime ChangedUtc { get; set; }

    public int? ChangedByEmployeeId { get; set; }

    public virtual Employee? ChangedByEmployee { get; set; }

    public virtual Product Product { get; set; } = null!;
}
