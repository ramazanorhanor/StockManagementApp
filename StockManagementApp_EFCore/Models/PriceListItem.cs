using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PriceListItem
{
    public int Id { get; set; }

    public int PriceListId { get; set; }

    public int ProductVariantId { get; set; }

    public int MinQuantity { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual PriceList PriceList { get; set; } = null!;

    public virtual ProductVariant ProductVariant { get; set; } = null!;
}
