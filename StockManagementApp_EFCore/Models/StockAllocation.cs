using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockAllocation
{
    public int Id { get; set; }

    public int StockReservationId { get; set; }

    public int LocationId { get; set; }

    public int AllocatedQty { get; set; }

    public DateTime AllocatedUtc { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual StockReservation StockReservation { get; set; } = null!;
}
