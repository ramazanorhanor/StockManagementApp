using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockAdjustment
{
    public int Id { get; set; }

    public string AdjustmentNo { get; set; } = null!;

    public int WarehouseId { get; set; }

    public int ReasonId { get; set; }

    public int? ApprovedByEmployeeId { get; set; }

    public string Status { get; set; } = null!;

    public virtual Employee? ApprovedByEmployee { get; set; }

    public virtual StockMovementReason Reason { get; set; } = null!;

    public virtual ICollection<StockAdjustmentLine> StockAdjustmentLine { get; set; } = new List<StockAdjustmentLine>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
