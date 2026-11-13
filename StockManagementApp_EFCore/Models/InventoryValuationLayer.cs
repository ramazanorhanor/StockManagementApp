using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class InventoryValuationLayer
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public DateTime LayerDateUtc { get; set; }

    public int OriginalQty { get; set; }

    public int RemainingQty { get; set; }

    public decimal UnitCost { get; set; }

    public long SourceMovementId { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual StockMovement SourceMovement { get; set; } = null!;
}
