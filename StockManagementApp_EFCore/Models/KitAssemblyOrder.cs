using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class KitAssemblyOrder
{
    public int Id { get; set; }

    public string OrderNo { get; set; } = null!;

    public int BomId { get; set; }

    public int WarehouseId { get; set; }

    public int PlannedQty { get; set; }

    public int ProducedQty { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? PlannedDateUtc { get; set; }

    public int? CompletedByEmployeeId { get; set; }

    public virtual BillOfMaterial Bom { get; set; } = null!;

    public virtual Employee? CompletedByEmployee { get; set; }

    public virtual ICollection<KitAssemblyConsumption> KitAssemblyConsumption { get; set; } = new List<KitAssemblyConsumption>();

    public virtual ICollection<KitAssemblyOutput> KitAssemblyOutput { get; set; } = new List<KitAssemblyOutput>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
