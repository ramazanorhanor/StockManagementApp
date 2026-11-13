using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SupplierQuoteLine
{
    public int Id { get; set; }

    public int SupplierQuoteId { get; set; }

    public int RfqLineId { get; set; }

    public int ProductVariantId { get; set; }

    public decimal UnitPrice { get; set; }

    public short? LeadTimeDays { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual Rfqline RfqLine { get; set; } = null!;

    public virtual SupplierQuote SupplierQuote { get; set; } = null!;
}
