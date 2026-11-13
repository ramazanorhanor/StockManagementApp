using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockCount
{
    public int Id { get; set; }

    public string CountNo { get; set; } = null!;

    public int WarehouseId { get; set; }

    public string CountType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? StartedUtc { get; set; }

    public DateTime? CompletedUtc { get; set; }

    public virtual ICollection<StockCountLine> StockCountLine { get; set; } = new List<StockCountLine>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
