using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class SalesOrderApproval
{
    public int Id { get; set; }

    public int SalesOrderId { get; set; }

    public int ApproverEmployeeId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? ActionUtc { get; set; }

    public virtual Employee ApproverEmployee { get; set; } = null!;

    public virtual SalesOrder SalesOrder { get; set; } = null!;
}
