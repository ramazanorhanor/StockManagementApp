using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesInvoice
{
    public int Id { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public int SalesOrderId { get; set; }

    public int CustomerId { get; set; }

    public DateOnly InvoiceDateUtc { get; set; }

    public decimal GrandTotal { get; set; }

    public string Status { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<SalesInvoiceLine> SalesInvoiceLine { get; set; } = new List<SalesInvoiceLine>();

    public virtual SalesOrder SalesOrder { get; set; } = null!;
}
