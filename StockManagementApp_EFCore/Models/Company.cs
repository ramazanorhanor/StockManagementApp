using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string TaxNumber { get; set; } = null!;

    public int BaseCurrencyId { get; set; }

    public virtual Currency BaseCurrency { get; set; } = null!;

    public virtual ICollection<Warehouse> Warehouse { get; set; } = new List<Warehouse>();
}
