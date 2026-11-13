using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesOrderLine
{
    public int Id { get; set; }

    public int SalesOrderId { get; set; }

    public int ProductVariantId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public int TaxCodeId { get; set; }

    public decimal? LineTotal { get; set; }

    public virtual ICollection<PickListLine> PickListLine { get; set; } = new List<PickListLine>();

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual ICollection<SalesInvoiceLine> SalesInvoiceLine { get; set; } = new List<SalesInvoiceLine>();

    public virtual SalesOrder SalesOrder { get; set; } = null!;

    public virtual ICollection<ShipmentLine> ShipmentLine { get; set; } = new List<ShipmentLine>();

    public virtual ICollection<StockReservation> StockReservation { get; set; } = new List<StockReservation>();

    public virtual TaxCode TaxCode { get; set; } = null!;
}
