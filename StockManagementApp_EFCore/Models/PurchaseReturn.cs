using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseReturn
{
    public int Id { get; set; }

    public string ReturnNo { get; set; } = null!;

    public int SupplierId { get; set; }

    public int PurchaseOrderId { get; set; }

    public int ReasonId { get; set; }

    public string Status { get; set; } = null!;

    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    public virtual ICollection<PurchaseReturnLine> PurchaseReturnLine { get; set; } = new List<PurchaseReturnLine>();

    public virtual StockMovementReason Reason { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
