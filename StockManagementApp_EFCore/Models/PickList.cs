using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PickList
{
    public int Id { get; set; }

    public string PickListNo { get; set; } = null!;

    public int SalesOrderId { get; set; }

    public int WarehouseId { get; set; }

    public string Status { get; set; } = null!;

    public int? AssignedToEmployeeId { get; set; }

    public virtual Employee? AssignedToEmployee { get; set; }

    public virtual ICollection<PickListLine> PickListLine { get; set; } = new List<PickListLine>();

    public virtual SalesOrder SalesOrder { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
