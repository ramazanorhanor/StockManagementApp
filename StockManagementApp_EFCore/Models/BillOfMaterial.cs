using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class BillOfMaterial
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public string Version { get; set; } = null!;

    public DateOnly EffectiveFrom { get; set; }

    public DateOnly? EffectiveTo { get; set; }

    public bool IsDefault { get; set; }

    public virtual ICollection<BillOfMaterialLine> BillOfMaterialLine { get; set; } = new List<BillOfMaterialLine>();

    public virtual ICollection<KitAssemblyOrder> KitAssemblyOrder { get; set; } = new List<KitAssemblyOrder>();

    public virtual ProductVariant ProductVariant { get; set; } = null!;
}
