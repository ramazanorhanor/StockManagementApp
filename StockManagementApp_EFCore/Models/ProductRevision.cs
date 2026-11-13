using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ProductRevision
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string RevisionCode { get; set; } = null!;

    public DateOnly EffectiveDate { get; set; }

    public string? ChangeReason { get; set; }

    public int? ApprovedByEmployeeId { get; set; }

    public virtual Employee? ApprovedByEmployee { get; set; }

    public virtual Product Product { get; set; } = null!;
}
