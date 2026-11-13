using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesInvoiceLine
{
    public int Id { get; set; }

    public int SalesInvoiceId { get; set; }

    public int SalesOrderLineId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual SalesInvoice SalesInvoice { get; set; } = null!;

    public virtual SalesOrderLine SalesOrderLine { get; set; } = null!;
}
