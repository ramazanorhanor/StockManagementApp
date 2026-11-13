using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesQuote
{
    public int Id { get; set; }

    public string QuoteNo { get; set; } = null!;

    public int CustomerId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? ValidUntilUtc { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<SalesQuoteLine> SalesQuoteLine { get; set; } = new List<SalesQuoteLine>();
}
