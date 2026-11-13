using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class UnitOfMeasure
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Uomclass { get; set; } = null!;

    public virtual ICollection<Product> Product { get; set; } = new List<Product>();

    public virtual ICollection<ProductBarcode> ProductBarcode { get; set; } = new List<ProductBarcode>();

    public virtual ICollection<UnitOfMeasureConversion> UnitOfMeasureConversionFromUom { get; set; } = new List<UnitOfMeasureConversion>();

    public virtual ICollection<UnitOfMeasureConversion> UnitOfMeasureConversionToUom { get; set; } = new List<UnitOfMeasureConversion>();
}
