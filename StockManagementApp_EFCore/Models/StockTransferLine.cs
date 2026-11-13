using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class StockTransferLine
{
    public int Id { get; set; }

    public int StockTransferId { get; set; }

    public int ProductVariantId { get; set; }

    public int? LotId { get; set; }

    public int RequestedQty { get; set; }

    public int ShippedQty { get; set; }

    public int ReceivedQty { get; set; }

    public virtual Lot? Lot { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual StockTransfer StockTransfer { get; set; } = null!;
}
