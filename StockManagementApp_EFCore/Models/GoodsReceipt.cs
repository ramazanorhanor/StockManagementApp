using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class GoodsReceipt
{
    public int Id { get; set; }

    public string GrnNo { get; set; } = null!;

    public int PurchaseOrderId { get; set; }

    public int WarehouseId { get; set; }

    public DateTime ReceivedDateUtc { get; set; }

    public int ReceivedByEmployeeId { get; set; }

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLine { get; set; } = new List<GoodsReceiptLine>();

    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    public virtual Employee ReceivedByEmployee { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
