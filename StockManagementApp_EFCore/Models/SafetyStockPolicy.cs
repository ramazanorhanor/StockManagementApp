using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SafetyStockPolicy
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public int WarehouseId { get; set; }

    public int MinLevel { get; set; }

    public int? MaxLevel { get; set; }

    public int ReorderPoint { get; set; }

    public int ReorderQty { get; set; }

    public short LeadTimeDays { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
