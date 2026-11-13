using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class BillOfMaterialLine
{
    public int Id { get; set; }

    public int BomId { get; set; }

    public int ComponentVariantId { get; set; }

    public decimal Quantity { get; set; }

    public int UomId { get; set; }

    public decimal ScrapPercent { get; set; }

    public virtual BillOfMaterial Bom { get; set; } = null!;

    public virtual ProductVariant ComponentVariant { get; set; } = null!;
}
