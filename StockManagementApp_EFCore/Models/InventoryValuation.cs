using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class InventoryValuation
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public int WarehouseId { get; set; }

    public DateOnly ValuationDateUtc { get; set; }

    public string Method { get; set; } = null!;

    public decimal UnitCost { get; set; }

    public int QuantityOnHand { get; set; }

    public decimal? TotalValue { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
