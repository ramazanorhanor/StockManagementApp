using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Lot
{
    public int Id { get; set; }

    public int ProductVariantId { get; set; }

    public string LotNumber { get; set; } = null!;

    public DateOnly? ManufactureDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? SupplierLotNo { get; set; }

    public int? ReceivedFromSupplierId { get; set; }

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLine { get; set; } = new List<GoodsReceiptLine>();

    public virtual ICollection<Inventory> Inventory { get; set; } = new List<Inventory>();

    public virtual ICollection<KitAssemblyConsumption> KitAssemblyConsumption { get; set; } = new List<KitAssemblyConsumption>();

    public virtual ICollection<KitAssemblyOutput> KitAssemblyOutput { get; set; } = new List<KitAssemblyOutput>();

    public virtual ICollection<PickListLine> PickListLine { get; set; } = new List<PickListLine>();

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual ICollection<PurchaseReturnLine> PurchaseReturnLine { get; set; } = new List<PurchaseReturnLine>();

    public virtual Supplier? ReceivedFromSupplier { get; set; }

    public virtual ICollection<SalesReturnLine> SalesReturnLine { get; set; } = new List<SalesReturnLine>();

    public virtual ICollection<ShipmentLine> ShipmentLine { get; set; } = new List<ShipmentLine>();

    public virtual ICollection<StockAdjustmentLine> StockAdjustmentLine { get; set; } = new List<StockAdjustmentLine>();

    public virtual ICollection<StockCountLine> StockCountLine { get; set; } = new List<StockCountLine>();

    public virtual ICollection<StockMovement> StockMovement { get; set; } = new List<StockMovement>();

    public virtual ICollection<StockTransferLine> StockTransferLine { get; set; } = new List<StockTransferLine>();
}
