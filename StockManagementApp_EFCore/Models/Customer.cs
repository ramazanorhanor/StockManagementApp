using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string TaxNumber { get; set; } = null!;

    public decimal CreditLimit { get; set; }

    public int DefaultCurrencyId { get; set; }

    public virtual Currency DefaultCurrency { get; set; } = null!;

    public virtual ICollection<SalesInvoice> SalesInvoice { get; set; } = new List<SalesInvoice>();

    public virtual ICollection<SalesOrder> SalesOrder { get; set; } = new List<SalesOrder>();

    public virtual ICollection<SalesQuote> SalesQuote { get; set; } = new List<SalesQuote>();

    public virtual ICollection<SalesReturn> SalesReturn { get; set; } = new List<SalesReturn>();
}
