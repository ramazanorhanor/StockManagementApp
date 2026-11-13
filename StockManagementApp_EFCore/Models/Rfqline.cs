using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class Rfqline
{
    public int Id { get; set; }

    public int RfqId { get; set; }

    public int ProductVariantId { get; set; }

    public int Quantity { get; set; }

    public DateOnly? RequiredDate { get; set; }

    public virtual ProductVariant ProductVariant { get; set; } = null!;

    public virtual RequestForQuotation Rfq { get; set; } = null!;

    public virtual ICollection<SupplierQuoteLine> SupplierQuoteLine { get; set; } = new List<SupplierQuoteLine>();
}
