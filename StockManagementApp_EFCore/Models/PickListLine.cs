using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PickListLine
{
    public int Id { get; set; }

    public int PickListId { get; set; }

    public int SalesOrderLineId { get; set; }

    public int LocationId { get; set; }

    public int? LotId { get; set; }

    public int RequestedQty { get; set; }

    public int PickedQty { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Lot? Lot { get; set; }

    public virtual PickList PickList { get; set; } = null!;

    public virtual SalesOrderLine SalesOrderLine { get; set; } = null!;
}
