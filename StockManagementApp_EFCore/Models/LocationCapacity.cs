using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class LocationCapacity
{
    public int Id { get; set; }

    public int LocationId { get; set; }

    public decimal? MaxWeight { get; set; }

    public decimal? MaxVolume { get; set; }

    public int? MaxQty { get; set; }

    public virtual Location Location { get; set; } = null!;
}
