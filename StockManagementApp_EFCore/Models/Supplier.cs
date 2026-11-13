using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string TaxNumber { get; set; } = null!;

    public int DefaultCurrencyId { get; set; }

    public short PaymentTermDays { get; set; }

    public virtual Currency DefaultCurrency { get; set; } = null!;

    public virtual ICollection<Lot> Lot { get; set; } = new List<Lot>();

    public virtual ICollection<ProductSupplier> ProductSupplier { get; set; } = new List<ProductSupplier>();

    public virtual ICollection<PurchaseInvoice> PurchaseInvoice { get; set; } = new List<PurchaseInvoice>();

    public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<PurchaseReturn> PurchaseReturn { get; set; } = new List<PurchaseReturn>();

    public virtual ICollection<SupplierQuote> SupplierQuote { get; set; } = new List<SupplierQuote>();
}
