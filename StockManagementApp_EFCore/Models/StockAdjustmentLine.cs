using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockAdjustmentLine
{
    public int Id { get; set; }

    public int StockAdjustmentId { get; set; }

    public int ProductVariantId { get; set; }

    public int LocationId { get; set; }

    public int? LotId { get; set; }

    public int Quantity { get; set; }

    public string Direction { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual StockAdjustment StockAdjustment { get; set; } = null!;
}
