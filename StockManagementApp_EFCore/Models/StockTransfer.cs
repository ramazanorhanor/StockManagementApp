using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockTransfer
{
    public int Id { get; set; }

    public string TransferNo { get; set; } = null!;

    public int FromWarehouseId { get; set; }

    public int ToWarehouseId { get; set; }

    public string Status { get; set; } = null!;

    public int RequestedByEmployeeId { get; set; }

    public virtual Warehouse FromWarehouse { get; set; } = null!;

    public virtual Employee RequestedByEmployee { get; set; } = null!;

    public virtual ICollection<StockTransferLine> StockTransferLine { get; set; } = new List<StockTransferLine>();

    public virtual Warehouse ToWarehouse { get; set; } = null!;
}
