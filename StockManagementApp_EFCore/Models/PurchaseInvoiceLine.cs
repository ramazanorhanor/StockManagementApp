using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseInvoiceLine
{
    public int Id { get; set; }

    public int PurchaseInvoiceId { get; set; }

    public int PurchaseOrderLineId { get; set; }

    public int GoodsReceiptLineId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual GoodsReceiptLine GoodsReceiptLine { get; set; } = null!;

    public virtual PurchaseInvoice PurchaseInvoice { get; set; } = null!;

    public virtual PurchaseOrderLine PurchaseOrderLine { get; set; } = null!;
}
