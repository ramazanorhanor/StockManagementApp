using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class PurchaseRequisition
{
    public int Id { get; set; }

    public string RequisitionNo { get; set; } = null!;

    public int RequestedByEmployeeId { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? RequiredDate { get; set; }

    public virtual ICollection<PurchaseRequisitionLine> PurchaseRequisitionLine { get; set; } = new List<PurchaseRequisitionLine>();

    public virtual Employee RequestedByEmployee { get; set; } = null!;
}
