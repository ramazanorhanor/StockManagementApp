using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Inventory
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public int LocationId { get; set; }

    public int? LotId { get; set; }

    public int QuantityOnHand { get; set; }

    public int QuantityReserved { get; set; }

    public int? QuantityAvailable { get; set; }

    public DateTime LastUpdatedUtc { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;
}
