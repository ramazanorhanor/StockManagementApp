using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseInvoice
{
    public int Id { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public int SupplierId { get; set; }

    public int PurchaseOrderId { get; set; }

    public DateOnly InvoiceDateUtc { get; set; }

    public DateOnly? DueDateUtc { get; set; }

    public decimal GrandTotal { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLine { get; set; } = new List<PurchaseInvoiceLine>();

    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
