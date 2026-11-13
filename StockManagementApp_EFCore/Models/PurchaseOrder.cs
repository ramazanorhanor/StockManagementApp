using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseOrder
{
    public int Id { get; set; }

    public string PoNo { get; set; } = null!;

    public int SupplierId { get; set; }

    public int CurrencyId { get; set; }

    public decimal ExchangeRate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime OrderDateUtc { get; set; }

    public int WarehouseId { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<GoodsReceipt> GoodsReceipt { get; set; } = new List<GoodsReceipt>();

    public virtual ICollection<PurchaseInvoice> PurchaseInvoice { get; set; } = new List<PurchaseInvoice>();

    public virtual ICollection<PurchaseOrderApproval> PurchaseOrderApproval { get; set; } = new List<PurchaseOrderApproval>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLine { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseReturn> PurchaseReturn { get; set; } = new List<PurchaseReturn>();

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
