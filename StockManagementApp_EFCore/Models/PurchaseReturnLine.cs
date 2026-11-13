using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseReturnLine
{
    public int Id { get; set; }

    public int PurchaseReturnId { get; set; }

    public int ProductVariantId { get; set; }

    public int Quantity { get; set; }

    public int? LotId { get; set; }

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual PurchaseReturn PurchaseReturn { get; set; } = null!;
}
