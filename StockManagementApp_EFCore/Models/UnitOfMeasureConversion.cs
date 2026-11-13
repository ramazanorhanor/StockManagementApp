using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class UnitOfMeasureConversion
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int FromUomId { get; set; }

    public int ToUomId { get; set; }

    public decimal ConversionFactor { get; set; }

    public virtual UnitOfMeasure FromUom { get; set; } = null!;

    public virtual Product? Product { get; set; }

    public virtual UnitOfMeasure ToUom { get; set; } = null!;
}
