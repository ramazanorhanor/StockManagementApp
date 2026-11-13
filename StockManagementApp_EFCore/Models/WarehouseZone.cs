using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class WarehouseZone
{
    public int Id { get; set; }

    public int WarehouseId { get; set; }

    public string Code { get; set; } = null!;

    public string ZoneType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Location> Location { get; set; } = new List<Location>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
