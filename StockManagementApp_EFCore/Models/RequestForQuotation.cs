using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class RequestForQuotation
{
    public int Id { get; set; }

    public string RfqNo { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? IssuedUtc { get; set; }

    public DateTime? DueUtc { get; set; }

    public virtual ICollection<Rfqline> Rfqline { get; set; } = new List<Rfqline>();

    public virtual ICollection<SupplierQuote> SupplierQuote { get; set; } = new List<SupplierQuote>();
}
