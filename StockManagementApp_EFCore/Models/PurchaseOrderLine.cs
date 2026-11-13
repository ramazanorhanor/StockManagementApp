using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseOrderLine
{
    public int Id { get; set; }

    public int PurchaseOrderId { get; set; }

    public int ProductVariantId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitCost { get; set; }

    public int TaxCodeId { get; set; }

    public decimal? LineTotal { get; set; }

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLine { get; set; } = new List<GoodsReceiptLine>();

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLine { get; set; } = new List<PurchaseInvoiceLine>();

    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    public virtual TaxCode TaxCode { get; set; } = null!;
}
