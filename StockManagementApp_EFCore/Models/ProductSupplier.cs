using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ProductSupplier
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public int SupplierId { get; set; }

    public string? SupplierSku { get; set; }

    public short? LeadTimeDays { get; set; }

    public decimal? LastPurchasePrice { get; set; }

    public bool IsPreferred { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
