using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesReturnLine
{
    public int Id { get; set; }

    public int SalesReturnId { get; set; }

    public int ProductVariantId { get; set; }

    public int Quantity { get; set; }

    public int? LotId { get; set; }

    public string Condition { get; set; } = null!;

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual SalesReturn SalesReturn { get; set; } = null!;
}
