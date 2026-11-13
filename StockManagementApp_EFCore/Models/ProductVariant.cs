using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class ProductVariant
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string VariantSku { get; set; } = null!;

    public bool IsDefault { get; set; }

    public bool IsActive { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Volume { get; set; }

    public virtual BillOfMaterial? BillOfMaterial { get; set; }

    public virtual ICollection<BillOfMaterialLine> BillOfMaterialLine { get; set; } = new List<BillOfMaterialLine>();

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLine { get; set; } = new List<GoodsReceiptLine>();

    public virtual ICollection<Inventory> Inventory { get; set; } = new List<Inventory>();

    public virtual ICollection<InventoryValuation> InventoryValuation { get; set; } = new List<InventoryValuation>();

    public virtual ICollection<InventoryValuationLayer> InventoryValuationLayer { get; set; } = new List<InventoryValuationLayer>();

    public virtual ICollection<KitAssemblyConsumption> KitAssemblyConsumption { get; set; } = new List<KitAssemblyConsumption>();

    public virtual ICollection<Lot> Lot { get; set; } = new List<Lot>();

    public virtual ICollection<PriceListItem> PriceListItem { get; set; } = new List<PriceListItem>();

    public virtual Product Product { get; set; } = null!;

    public virtual ProductBarcode? ProductBarcode { get; set; }

    public virtual ProductSupplier? ProductSupplier { get; set; }

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLine { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseRequisitionLine> PurchaseRequisitionLine { get; set; } = new List<PurchaseRequisitionLine>();

    public virtual ICollection<PurchaseReturnLine> PurchaseReturnLine { get; set; } = new List<PurchaseReturnLine>();

    public virtual ICollection<Rfqline> Rfqline { get; set; } = new List<Rfqline>();

    public virtual ICollection<SafetyStockPolicy> SafetyStockPolicy { get; set; } = new List<SafetyStockPolicy>();

    public virtual ICollection<SalesOrderLine> SalesOrderLine { get; set; } = new List<SalesOrderLine>();

    public virtual ICollection<SalesQuoteLine> SalesQuoteLine { get; set; } = new List<SalesQuoteLine>();

    public virtual ICollection<SalesReturnLine> SalesReturnLine { get; set; } = new List<SalesReturnLine>();

    public virtual ICollection<SerialNumber> SerialNumber { get; set; } = new List<SerialNumber>();

    public virtual ICollection<ShipmentLine> ShipmentLine { get; set; } = new List<ShipmentLine>();

    public virtual ICollection<StockAdjustmentLine> StockAdjustmentLine { get; set; } = new List<StockAdjustmentLine>();

    public virtual ICollection<StockCountLine> StockCountLine { get; set; } = new List<StockCountLine>();

    public virtual ICollection<StockMovement> StockMovement { get; set; } = new List<StockMovement>();

    public virtual ICollection<StockReservation> StockReservation { get; set; } = new List<StockReservation>();

    public virtual ICollection<StockTransferLine> StockTransferLine { get; set; } = new List<StockTransferLine>();

    public virtual ICollection<SupplierQuoteLine> SupplierQuoteLine { get; set; } = new List<SupplierQuoteLine>();

    public virtual ICollection<ProductAttributeValue> ProductAttributeValue { get; set; } = new List<ProductAttributeValue>();
}
