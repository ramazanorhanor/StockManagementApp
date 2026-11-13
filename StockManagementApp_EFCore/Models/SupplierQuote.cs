using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SupplierQuote
{
    public int Id { get; set; }

    public int RfqId { get; set; }

    public int SupplierId { get; set; }

    public int CurrencyId { get; set; }

    public DateTime? ValidUntilUtc { get; set; }

    public string Status { get; set; } = null!;

    public virtual Currency Currency { get; set; } = null!;

    public virtual RequestForQuotation Rfq { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<SupplierQuoteLine> SupplierQuoteLine { get; set; } = new List<SupplierQuoteLine>();
}
