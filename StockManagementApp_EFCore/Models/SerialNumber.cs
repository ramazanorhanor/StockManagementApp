using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SerialNumber
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public string SerialNo { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateOnly? ManufactureDate { get; set; }

    public DateOnly? WarrantyEndDate { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual ICollection<StockMovement> StockMovement { get; set; } = new List<StockMovement>();
}
