using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual ICollection<GoodsReceipt> GoodsReceipt { get; set; } = new List<GoodsReceipt>();

    public virtual ICollection<KitAssemblyOrder> KitAssemblyOrder { get; set; } = new List<KitAssemblyOrder>();

    public virtual ICollection<PickList> PickList { get; set; } = new List<PickList>();

    public virtual ICollection<ProductLifecycle> ProductLifecycle { get; set; } = new List<ProductLifecycle>();

    public virtual ICollection<ProductRevision> ProductRevision { get; set; } = new List<ProductRevision>();

    public virtual ICollection<PurchaseOrderApproval> PurchaseOrderApproval { get; set; } = new List<PurchaseOrderApproval>();

    public virtual ICollection<PurchaseRequisition> PurchaseRequisition { get; set; } = new List<PurchaseRequisition>();

    public virtual ICollection<SalesOrderApproval> SalesOrderApproval { get; set; } = new List<SalesOrderApproval>();

    public virtual ICollection<StockAdjustment> StockAdjustment { get; set; } = new List<StockAdjustment>();

    public virtual ICollection<StockCountLine> StockCountLine { get; set; } = new List<StockCountLine>();

    public virtual ICollection<StockMovement> StockMovement { get; set; } = new List<StockMovement>();

    public virtual ICollection<StockTransfer> StockTransfer { get; set; } = new List<StockTransfer>();
}
