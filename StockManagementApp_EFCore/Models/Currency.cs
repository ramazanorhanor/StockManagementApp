using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Currency
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    public byte DecimalPlaces { get; set; }

    public virtual ICollection<Company> Company { get; set; } = new List<Company>();

    public virtual ICollection<Customer> Customer { get; set; } = new List<Customer>();

    public virtual ICollection<ExchangeRate> ExchangeRateFromCurrency { get; set; } = new List<ExchangeRate>();

    public virtual ICollection<ExchangeRate> ExchangeRateToCurrency { get; set; } = new List<ExchangeRate>();

    public virtual ICollection<PriceList> PriceList { get; set; } = new List<PriceList>();

    public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<SalesOrder> SalesOrder { get; set; } = new List<SalesOrder>();

    public virtual ICollection<Supplier> Supplier { get; set; } = new List<Supplier>();

    public virtual ICollection<SupplierQuote> SupplierQuote { get; set; } = new List<SupplierQuote>();
}
