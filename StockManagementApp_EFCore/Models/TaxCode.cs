using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class TaxCode
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal RatePercent { get; set; }

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLine { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<SalesOrderLine> SalesOrderLine { get; set; } = new List<SalesOrderLine>();
}
