using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Location
{
    public int Id { get; set; }

    public int WarehouseZoneId { get; set; }

    public int? ParentLocationId { get; set; }

    public string Code { get; set; } = null!;

    public string LocationType { get; set; } = null!;

    public bool IsPickable { get; set; }

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLine { get; set; } = new List<GoodsReceiptLine>();

    public virtual ICollection<Inventory> Inventory { get; set; } = new List<Inventory>();

    public virtual ICollection<Location> InverseParentLocation { get; set; } = new List<Location>();

    public virtual ICollection<KitAssemblyConsumption> KitAssemblyConsumption { get; set; } = new List<KitAssemblyConsumption>();

    public virtual ICollection<KitAssemblyOutput> KitAssemblyOutput { get; set; } = new List<KitAssemblyOutput>();

    public virtual LocationCapacity? LocationCapacity { get; set; }

    public virtual Location? ParentLocation { get; set; }

    public virtual ICollection<PickListLine> PickListLine { get; set; } = new List<PickListLine>();

    public virtual ICollection<StockAdjustmentLine> StockAdjustmentLine { get; set; } = new List<StockAdjustmentLine>();

    public virtual ICollection<StockAllocation> StockAllocation { get; set; } = new List<StockAllocation>();

    public virtual ICollection<StockCountLine> StockCountLine { get; set; } = new List<StockCountLine>();

    public virtual ICollection<StockMovement> StockMovement { get; set; } = new List<StockMovement>();

    public virtual ICollection<StockReservation> StockReservation { get; set; } = new List<StockReservation>();

    public virtual WarehouseZone WarehouseZone { get; set; } = null!;
}
