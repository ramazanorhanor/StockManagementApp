using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockMovement
{
    public long Id { get; set; }

    public string MovementNo { get; set; } = null!;

    public int ProductVariantId { get; set; }

    public int LocationId { get; set; }

    public int? LotId { get; set; }

    public int? SerialId { get; set; }

    public string MovementType { get; set; } = null!;

    public int Quantity { get; set; }

    public DateTime MovementDateUtc { get; set; }

    public string ReferenceType { get; set; } = null!;

    public int ReferenceId { get; set; }

    public int ReasonId { get; set; }

    public int CreatedByEmployeeId { get; set; }

    public virtual Employee CreatedByEmployee { get; set; } = null!;

    public virtual ICollection<InventoryValuationLayer> InventoryValuationLayer { get; set; } = new List<InventoryValuationLayer>();

    public virtual Location Location { get; set; } = null!;

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual StockMovementReason Reason { get; set; } = null!;

    public virtual SerialNumber? Serial { get; set; }
}
