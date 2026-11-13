using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PriceList
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int CurrencyId { get; set; }

    public DateOnly ValidFrom { get; set; }

    public DateOnly? ValidTo { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<PriceListItem> PriceListItem { get; set; } = new List<PriceListItem>();
}
