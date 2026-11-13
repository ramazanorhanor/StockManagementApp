using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesQuoteLine
{
    public int Id { get; set; }

    public int SalesQuoteId { get; set; }

    public int ProductVariantId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual SalesQuote SalesQuote { get; set; } = null!;
}
