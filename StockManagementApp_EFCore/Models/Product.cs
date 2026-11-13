using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Product
{
    public int Id { get; set; }

    public string BaseSku { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int CategoryId { get; set; }

    public int? BrandId { get; set; }

    public int? ManufacturerId { get; set; }

    public int BaseUomId { get; set; }

    public string ProductType { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsSellable { get; set; }

    public bool IsPurchasable { get; set; }

    public virtual UnitOfMeasure BaseUom { get; set; } = null!;

    public virtual Brand? Brand { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual ICollection<ProductLifecycle> ProductLifecycle { get; set; } = new List<ProductLifecycle>();

    public virtual ICollection<ProductRevision> ProductRevision { get; set; } = new List<ProductRevision>();

    public virtual ProductVariant? ProductVariant { get; set; }

    public virtual ICollection<UnitOfMeasureConversion> UnitOfMeasureConversion { get; set; } = new List<UnitOfMeasureConversion>();
}
