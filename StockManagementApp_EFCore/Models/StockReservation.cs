using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockReservation
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public int LocationId { get; set; }

    public int SalesOrderLineId { get; set; }

    public int ReservedQuantity { get; set; }

    public DateTime ReservedUtc { get; set; }

    public DateTime? ExpiresUtc { get; set; }

    public string Status { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual SalesOrderLine SalesOrderLine { get; set; } = null!;

    public virtual ICollection<StockAllocation> StockAllocation { get; set; } = new List<StockAllocation>();
}
