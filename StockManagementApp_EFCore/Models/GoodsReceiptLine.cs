using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class GoodsReceiptLine
{
    public int Id { get; set; }

    public int GoodsReceiptId { get; set; }

    public int PurchaseOrderLineId { get; set; }

    public int ProductVariantId { get; set; }

    public int ReceivedQty { get; set; }

    public int RejectedQty { get; set; }

    public int? LotId { get; set; }

    public int LocationId { get; set; }

    public virtual GoodsReceipt GoodsReceipt { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLine { get; set; } = new List<PurchaseInvoiceLine>();

    public virtual PurchaseOrderLine PurchaseOrderLine { get; set; } = null!;
}
