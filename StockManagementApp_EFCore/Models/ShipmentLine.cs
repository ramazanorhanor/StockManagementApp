using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ShipmentLine
{
    public int Id { get; set; }

    public int ShipmentId { get; set; }

    public int SalesOrderLineId { get; set; }

    public int ProductVariantId { get; set; }

    public int Quantity { get; set; }

    public int? LotId { get; set; }

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual SalesOrderLine SalesOrderLine { get; set; } = null!;

    public virtual Shipment Shipment { get; set; } = null!;
}
