using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ExchangeRate
{
    public int Id { get; set; }

    public int FromCurrencyId { get; set; }

    public int ToCurrencyId { get; set; }

    public DateOnly RateDateUtc { get; set; }

    public decimal Rate { get; set; }

    public virtual Currency FromCurrency { get; set; } = null!;

    public virtual Currency ToCurrency { get; set; } = null!;
}
