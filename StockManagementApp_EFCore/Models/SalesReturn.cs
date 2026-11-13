using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesReturn
{
    public int Id { get; set; }

    public string RmaNo { get; set; } = null!;

    public int SalesOrderId { get; set; }

    public int CustomerId { get; set; }

    public int ReasonId { get; set; }

    public string Status { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual StockMovementReason Reason { get; set; } = null!;

    public virtual SalesOrder SalesOrder { get; set; } = null!;

    public virtual ICollection<SalesReturnLine> SalesReturnLine { get; set; } = new List<SalesReturnLine>();
}
