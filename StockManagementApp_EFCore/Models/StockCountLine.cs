using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockCountLine
{
    public int Id { get; set; }

    public int StockCountId { get; set; }

    public int ProductVariantId { get; set; }

    public int LocationId { get; set; }

    public int? LotId { get; set; }

    public int SystemQty { get; set; }

    public int? CountedQty { get; set; }

    public int? VarianceQty { get; set; }

    public int? CountedByEmployeeId { get; set; }

    public virtual Employee? CountedByEmployee { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual StockCount StockCount { get; set; } = null!;
}
