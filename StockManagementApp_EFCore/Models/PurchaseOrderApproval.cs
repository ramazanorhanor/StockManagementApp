using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseOrderApproval
{
    public int Id { get; set; }

    public int PurchaseOrderId { get; set; }

    public int ApproverEmployeeId { get; set; }

    public byte StepOrder { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? ActionUtc { get; set; }

    public virtual Employee ApproverEmployee { get; set; } = null!;

    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;
}
