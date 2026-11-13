using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Shipment
{
    public int Id { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public int SalesOrderId { get; set; }

    public int WarehouseId { get; set; }

    public DateTime? ShippedUtc { get; set; }

    public string? TrackingNo { get; set; }

    public virtual SalesOrder SalesOrder { get; set; } = null!;

    public virtual ICollection<ShipmentLine> ShipmentLine { get; set; } = new List<ShipmentLine>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
