using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ProductBarcode
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public string Barcode { get; set; } = null!;

    public int UomId { get; set; }

    public bool IsPrimary { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual UnitOfMeasure Uom { get; set; } = null!;
}
