using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class KitAssemblyConsumption
{
    public int Id { get; set; }

    public int KitAssemblyOrderId { get; set; }

    public int ComponentVariantId { get; set; }

    public int LocationId { get; set; }

    public int? LotId { get; set; }

    public decimal ConsumedQty { get; set; }

    public virtual ProductVariant ComponentVariant { get; set; } = null!;

    public virtual KitAssemblyOrder KitAssemblyOrder { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Lot? Lot { get; set; }
}
