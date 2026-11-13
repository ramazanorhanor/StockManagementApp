using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseRequisitionLine
{
    public int Id { get; set; }

    public int PurchaseRequisitionId { get; set; }

    public int ProductVariantId { get; set; }

    public int Quantity { get; set; }

    public decimal? EstimatedPrice { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual PurchaseRequisition PurchaseRequisition { get; set; } = null!;
}
