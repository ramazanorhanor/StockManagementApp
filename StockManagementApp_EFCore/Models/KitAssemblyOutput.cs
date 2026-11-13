using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class KitAssemblyOutput
{
    public int Id { get; set; }

    public int KitAssemblyOrderId { get; set; }

    public int? OutputLotId { get; set; }

    public int ProducedQty { get; set; }

    public int LocationId { get; set; }

    public virtual KitAssemblyOrder KitAssemblyOrder { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Lot? OutputLot { get; set; }
}
