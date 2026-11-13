using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? City { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<GoodsReceipt> GoodsReceipt { get; set; } = new List<GoodsReceipt>();

    public virtual ICollection<InventoryValuation> InventoryValuation { get; set; } = new List<InventoryValuation>();

    public virtual ICollection<KitAssemblyOrder> KitAssemblyOrder { get; set; } = new List<KitAssemblyOrder>();

    public virtual ICollection<PickList> PickList { get; set; } = new List<PickList>();

    public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<SafetyStockPolicy> SafetyStockPolicy { get; set; } = new List<SafetyStockPolicy>();

    public virtual ICollection<SalesOrder> SalesOrder { get; set; } = new List<SalesOrder>();

    public virtual ICollection<Shipment> Shipment { get; set; } = new List<Shipment>();

    public virtual ICollection<StockAdjustment> StockAdjustment { get; set; } = new List<StockAdjustment>();

    public virtual ICollection<StockCount> StockCount { get; set; } = new List<StockCount>();

    public virtual ICollection<StockTransfer> StockTransferFromWarehouse { get; set; } = new List<StockTransfer>();

    public virtual ICollection<StockTransfer> StockTransferToWarehouse { get; set; } = new List<StockTransfer>();

    public virtual ICollection<WarehouseZone> WarehouseZone { get; set; } = new List<WarehouseZone>();
}
