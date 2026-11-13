using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockMovementReason
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string MovementCategory { get; set; } = null!;

    public virtual ICollection<PurchaseReturn> PurchaseReturn { get; set; } = new List<PurchaseReturn>();

    public virtual ICollection<SalesReturn> SalesReturn { get; set; } = new List<SalesReturn>();

    public virtual ICollection<StockAdjustment> StockAdjustment { get; set; } = new List<StockAdjustment>();

    public virtual ICollection<StockMovement> StockMovement { get; set; } = new List<StockMovement>();
}
