using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesOrder
{
    public int Id { get; set; }

    public string OrderNo { get; set; } = null!;

    public int CustomerId { get; set; }

    public int CurrencyId { get; set; }

    public decimal ExchangeRate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime OrderDateUtc { get; set; }

    public int WarehouseId { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<PickList> PickList { get; set; } = new List<PickList>();

    public virtual ICollection<SalesInvoice> SalesInvoice { get; set; } = new List<SalesInvoice>();

    public virtual ICollection<SalesOrderApproval> SalesOrderApproval { get; set; } = new List<SalesOrderApproval>();

    public virtual ICollection<SalesOrderLine> SalesOrderLine { get; set; } = new List<SalesOrderLine>();

    public virtual ICollection<SalesReturn> SalesReturn { get; set; } = new List<SalesReturn>();

    public virtual ICollection<Shipment> Shipment { get; set; } = new List<Shipment>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
