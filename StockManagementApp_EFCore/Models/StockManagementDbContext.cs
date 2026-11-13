using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StockManagementApp_EFCore.Models;

public partial class StockManagementDbContext : DbContext
{
    public StockManagementDbContext()
    {
    }

    public StockManagementDbContext(DbContextOptions<StockManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdreslerUrl> AdreslerUrl { get; set; }

    public virtual DbSet<BillOfMaterial> BillOfMaterial { get; set; }

    public virtual DbSet<BillOfMaterialLine> BillOfMaterialLine { get; set; }

    public virtual DbSet<Brand> Brand { get; set; }

    public virtual DbSet<Category> Category { get; set; }

    public virtual DbSet<Company> Company { get; set; }

    public virtual DbSet<Currency> Currency { get; set; }

    public virtual DbSet<Customer> Customer { get; set; }

    public virtual DbSet<Employee> Employee { get; set; }

    public virtual DbSet<ExchangeRate> ExchangeRate { get; set; }

    public virtual DbSet<GoodsReceipt> GoodsReceipt { get; set; }

    public virtual DbSet<GoodsReceiptLine> GoodsReceiptLine { get; set; }

    public virtual DbSet<Inventory> Inventory { get; set; }

    public virtual DbSet<InventoryValuation> InventoryValuation { get; set; }

    public virtual DbSet<InventoryValuationLayer> InventoryValuationLayer { get; set; }

    public virtual DbSet<KitAssemblyConsumption> KitAssemblyConsumption { get; set; }

    public virtual DbSet<KitAssemblyOrder> KitAssemblyOrder { get; set; }

    public virtual DbSet<KitAssemblyOutput> KitAssemblyOutput { get; set; }

    public virtual DbSet<Location> Location { get; set; }

    public virtual DbSet<LocationCapacity> LocationCapacity { get; set; }

    public virtual DbSet<Lot> Lot { get; set; }

    public virtual DbSet<Manufacturer> Manufacturer { get; set; }

    public virtual DbSet<Numbers> Numbers { get; set; }

    public virtual DbSet<PickList> PickList { get; set; }

    public virtual DbSet<PickListLine> PickListLine { get; set; }

    public virtual DbSet<PriceList> PriceList { get; set; }

    public virtual DbSet<PriceListItem> PriceListItem { get; set; }

    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttribute { get; set; }

    public virtual DbSet<ProductAttributeValue> ProductAttributeValue { get; set; }

    public virtual DbSet<ProductBarcode> ProductBarcode { get; set; }

    public virtual DbSet<ProductLifecycle> ProductLifecycle { get; set; }

    public virtual DbSet<ProductRevision> ProductRevision { get; set; }

    public virtual DbSet<ProductSupplier> ProductSupplier { get; set; }

    public virtual DbSet<ProductVariant> ProductVariant { get; set; }

    public virtual DbSet<PurchaseInvoice> PurchaseInvoice { get; set; }

    public virtual DbSet<PurchaseInvoiceLine> PurchaseInvoiceLine { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }

    public virtual DbSet<PurchaseOrderApproval> PurchaseOrderApproval { get; set; }

    public virtual DbSet<PurchaseOrderLine> PurchaseOrderLine { get; set; }

    public virtual DbSet<PurchaseRequisition> PurchaseRequisition { get; set; }

    public virtual DbSet<PurchaseRequisitionLine> PurchaseRequisitionLine { get; set; }

    public virtual DbSet<PurchaseReturn> PurchaseReturn { get; set; }

    public virtual DbSet<PurchaseReturnLine> PurchaseReturnLine { get; set; }

    public virtual DbSet<RequestForQuotation> RequestForQuotation { get; set; }

    public virtual DbSet<Rfqline> Rfqline { get; set; }

    public virtual DbSet<SafetyStockPolicy> SafetyStockPolicy { get; set; }

    public virtual DbSet<SalesInvoice> SalesInvoice { get; set; }

    public virtual DbSet<SalesInvoiceLine> SalesInvoiceLine { get; set; }

    public virtual DbSet<SalesOrder> SalesOrder { get; set; }

    public virtual DbSet<SalesOrderApproval> SalesOrderApproval { get; set; }

    public virtual DbSet<SalesOrderLine> SalesOrderLine { get; set; }

    public virtual DbSet<SalesQuote> SalesQuote { get; set; }

    public virtual DbSet<SalesQuoteLine> SalesQuoteLine { get; set; }

    public virtual DbSet<SalesReturn> SalesReturn { get; set; }

    public virtual DbSet<SalesReturnLine> SalesReturnLine { get; set; }

    public virtual DbSet<SerialNumber> SerialNumber { get; set; }

    public virtual DbSet<Shipment> Shipment { get; set; }

    public virtual DbSet<ShipmentLine> ShipmentLine { get; set; }

    public virtual DbSet<StockAdjustment> StockAdjustment { get; set; }

    public virtual DbSet<StockAdjustmentLine> StockAdjustmentLine { get; set; }

    public virtual DbSet<StockAllocation> StockAllocation { get; set; }

    public virtual DbSet<StockCount> StockCount { get; set; }

    public virtual DbSet<StockCountLine> StockCountLine { get; set; }

    public virtual DbSet<StockMovement> StockMovement { get; set; }

    public virtual DbSet<StockMovementReason> StockMovementReason { get; set; }

    public virtual DbSet<StockReservation> StockReservation { get; set; }

    public virtual DbSet<StockTransfer> StockTransfer { get; set; }

    public virtual DbSet<StockTransferLine> StockTransferLine { get; set; }

    public virtual DbSet<Supplier> Supplier { get; set; }

    public virtual DbSet<SupplierQuote> SupplierQuote { get; set; }

    public virtual DbSet<SupplierQuoteLine> SupplierQuoteLine { get; set; }

    public virtual DbSet<TaxCode> TaxCode { get; set; }

    public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }

    public virtual DbSet<UnitOfMeasureConversion> UnitOfMeasureConversion { get; set; }

    public virtual DbSet<VwAnlamliVeriTesti> VwAnlamliVeriTesti { get; set; }

    public virtual DbSet<VwBostablokontrolu> VwBostablokontrolu { get; set; }

    public virtual DbSet<VwIliskiselbutunlukkontrolleri> VwIliskiselbutunlukkontrolleri { get; set; }

    public virtual DbSet<VwKritiktablolarinSatirSayilari> VwKritiktablolarinSatirSayilari { get; set; }

    public virtual DbSet<VwSorgu5TablolardakiSatirSayisi> VwSorgu5TablolardakiSatirSayisi { get; set; }

    public virtual DbSet<VwSorgu6VeriButunluguFkCheckIhlali> VwSorgu6VeriButunluguFkCheckIhlali { get; set; }

    public virtual DbSet<Warehouse> Warehouse { get; set; }

    public virtual DbSet<WarehouseZone> WarehouseZone { get; set; }

    public virtual DbSet<ZzBillOfMaterialLineYedek> ZzBillOfMaterialLineYedek { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StockManagementERP;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdreslerUrl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AdreslerURL");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("aciklama");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SqlQuery).HasColumnName("sqlQuery");
        });

        modelBuilder.Entity<BillOfMaterial>(entity =>
        {
            entity.HasIndex(e => e.ProductVariantId, "UQ_BillOfMaterial_OneDefaultPerVariant")
                .IsUnique()
                .HasFilter("([IsDefault]=(1))");

            entity.HasIndex(e => new { e.ProductVariantId, e.Version }, "UQ_BillOfMaterial_VariantVersion").IsUnique();

            entity.Property(e => e.IsDefault).HasDefaultValue(true, "DF_BillOfMaterial_IsDefault");
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .HasDefaultValue("v1", "DF_BillOfMaterial_Version");

            entity.HasOne(d => d.ProductVariant).WithOne(p => p.BillOfMaterial)
                .HasForeignKey<BillOfMaterial>(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterial_Variant");
        });

        modelBuilder.Entity<BillOfMaterialLine>(entity =>
        {
            entity.HasIndex(e => e.BomId, "IX_BillOfMaterialLine_BomId");

            entity.HasIndex(e => e.ComponentVariantId, "IX_BillOfMaterialLine_ComponentVariantId");

            entity.HasIndex(e => new { e.BomId, e.ComponentVariantId }, "UQ_BillOfMaterialLine_BomComponent").IsUnique();

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ScrapPercent).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Bom).WithMany(p => p.BillOfMaterialLine)
                .HasForeignKey(d => d.BomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialLine_Bom");

            entity.HasOne(d => d.ComponentVariant).WithMany(p => p.BillOfMaterialLine)
                .HasForeignKey(d => d.ComponentVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillOfMaterialLine_Component");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasIndex(e => e.Name, "UQ_Brand_Name").IsUnique();

            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasIndex(e => e.ParentCategoryId, "IX_Category_ParentCategoryId");

            entity.HasIndex(e => new { e.ParentCategoryId, e.Name }, "UQ_Category_Name_PerParent")
                .IsUnique()
                .HasFilter("([ParentCategoryId] IS NOT NULL)");

            entity.HasIndex(e => e.Name, "UQ_Category_Name_RootLevel")
                .IsUnique()
                .HasFilter("([ParentCategoryId] IS NULL)");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Path).HasMaxLength(400);

            entity.HasOne(d => d.ParentCategory).WithMany(p => p.InverseParentCategory)
                .HasForeignKey(d => d.ParentCategoryId)
                .HasConstraintName("FK_Category_Parent");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasIndex(e => e.TaxNumber, "UQ_Company_TaxNumber").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.TaxNumber).HasMaxLength(20);

            entity.HasOne(d => d.BaseCurrency).WithMany(p => p.Company)
                .HasForeignKey(d => d.BaseCurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Company_BaseCurrency");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasIndex(e => e.Code, "UQ_Currency_Code").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DecimalPlaces).HasDefaultValue((byte)2, "DF_Currency_DecimalPlaces");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Symbol).HasMaxLength(5);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasIndex(e => e.TaxNumber, "UQ_Customer_TaxNumber").IsUnique();

            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.TaxNumber).HasMaxLength(20);

            entity.HasOne(d => d.DefaultCurrency).WithMany(p => p.Customer)
                .HasForeignKey(d => d.DefaultCurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_DefaultCurrency");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        modelBuilder.Entity<ExchangeRate>(entity =>
        {
            entity.HasIndex(e => new { e.FromCurrencyId, e.ToCurrencyId, e.RateDateUtc }, "IX_ExchangeRate_Lookup").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.FromCurrencyId, e.ToCurrencyId, e.RateDateUtc }, "UQ_ExchangeRate_Pair_Date").IsUnique();

            entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.FromCurrency).WithMany(p => p.ExchangeRateFromCurrency)
                .HasForeignKey(d => d.FromCurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExchangeRate_FromCurrency");

            entity.HasOne(d => d.ToCurrency).WithMany(p => p.ExchangeRateToCurrency)
                .HasForeignKey(d => d.ToCurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExchangeRate_ToCurrency");
        });

        modelBuilder.Entity<GoodsReceipt>(entity =>
        {
            entity.HasIndex(e => e.PurchaseOrderId, "IX_GoodsReceipt_PurchaseOrderId");

            entity.HasIndex(e => e.GrnNo, "UQ_GoodsReceipt_GrnNo").IsUnique();

            entity.Property(e => e.GrnNo).HasMaxLength(30);
            entity.Property(e => e.ReceivedDateUtc)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_GoodsReceipt_ReceivedDateUtc");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.GoodsReceipt)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceipt_Order");

            entity.HasOne(d => d.ReceivedByEmployee).WithMany(p => p.GoodsReceipt)
                .HasForeignKey(d => d.ReceivedByEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceipt_ReceivedBy");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.GoodsReceipt)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceipt_Warehouse");
        });

        modelBuilder.Entity<GoodsReceiptLine>(entity =>
        {
            entity.HasIndex(e => e.GoodsReceiptId, "IX_GoodsReceiptLine_GoodsReceiptId");

            entity.HasIndex(e => e.PurchaseOrderLineId, "IX_GoodsReceiptLine_PurchaseOrderLineId");

            entity.HasOne(d => d.GoodsReceipt).WithMany(p => p.GoodsReceiptLine)
                .HasForeignKey(d => d.GoodsReceiptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceiptLine_Receipt");

            entity.HasOne(d => d.Location).WithMany(p => p.GoodsReceiptLine)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceiptLine_Location");

            entity.HasOne(d => d.Lot).WithMany(p => p.GoodsReceiptLine)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_GoodsReceiptLine_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.GoodsReceiptLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceiptLine_Variant");

            entity.HasOne(d => d.PurchaseOrderLine).WithMany(p => p.GoodsReceiptLine)
                .HasForeignKey(d => d.PurchaseOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceiptLine_OrderLine");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasIndex(e => e.LocationId, "IX_Inventory_LocationId");

            entity.HasIndex(e => new { e.ProductVariantId, e.LocationId, e.LotId }, "UQ_Inventory_WithLot")
                .IsUnique()
                .HasFilter("([LotId] IS NOT NULL)");

            entity.HasIndex(e => new { e.ProductVariantId, e.LocationId }, "UQ_Inventory_WithoutLot")
                .IsUnique()
                .HasFilter("([LotId] IS NULL)");

            entity.Property(e => e.LastUpdatedUtc)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_Inventory_LastUpdatedUtc");
            entity.Property(e => e.QuantityAvailable).HasComputedColumnSql("([QuantityOnHand]-[QuantityReserved])", true);

            entity.HasOne(d => d.Location).WithMany(p => p.Inventory)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Location");

            entity.HasOne(d => d.Lot).WithMany(p => p.Inventory)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_Inventory_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.Inventory)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Variant");
        });

        modelBuilder.Entity<InventoryValuation>(entity =>
        {
            entity.HasIndex(e => new { e.ProductVariantId, e.WarehouseId, e.ValuationDateUtc }, "UQ_InventoryValuation_Snapshot").IsUnique();

            entity.Property(e => e.Method).HasMaxLength(15);
            entity.Property(e => e.TotalValue)
                .HasComputedColumnSql("([UnitCost]*[QuantityOnHand])", true)
                .HasColumnType("decimal(29, 4)");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.InventoryValuation)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryValuation_Variant");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InventoryValuation)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryValuation_Warehouse");
        });

        modelBuilder.Entity<InventoryValuationLayer>(entity =>
        {
            entity.HasIndex(e => new { e.ProductVariantId, e.LayerDateUtc }, "IX_InventoryValuationLayer_Product_LayerDate");

            entity.Property(e => e.LayerDateUtc).HasPrecision(3);
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.InventoryValuationLayer)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryValuationLayer_Variant");

            entity.HasOne(d => d.SourceMovement).WithMany(p => p.InventoryValuationLayer)
                .HasForeignKey(d => d.SourceMovementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryValuationLayer_Movement");
        });

        modelBuilder.Entity<KitAssemblyConsumption>(entity =>
        {
            entity.HasIndex(e => e.KitAssemblyOrderId, "IX_KitAssemblyConsumption_OrderId");

            entity.Property(e => e.ConsumedQty).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ComponentVariant).WithMany(p => p.KitAssemblyConsumption)
                .HasForeignKey(d => d.ComponentVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitAssemblyConsumption_Component");

            entity.HasOne(d => d.KitAssemblyOrder).WithMany(p => p.KitAssemblyConsumption)
                .HasForeignKey(d => d.KitAssemblyOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitAssemblyConsumption_Order");

            entity.HasOne(d => d.Location).WithMany(p => p.KitAssemblyConsumption)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitAssemblyConsumption_Location");

            entity.HasOne(d => d.Lot).WithMany(p => p.KitAssemblyConsumption)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_KitAssemblyConsumption_Lot");
        });

        modelBuilder.Entity<KitAssemblyOrder>(entity =>
        {
            entity.HasIndex(e => e.BomId, "IX_KitAssemblyOrder_BomId");

            entity.HasIndex(e => e.OrderNo, "UQ_KitAssemblyOrder_OrderNo").IsUnique();

            entity.Property(e => e.OrderNo).HasMaxLength(30);
            entity.Property(e => e.PlannedDateUtc).HasPrecision(3);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Draft", "DF_KitAssemblyOrder_Status");

            entity.HasOne(d => d.Bom).WithMany(p => p.KitAssemblyOrder)
                .HasForeignKey(d => d.BomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitAssemblyOrder_Bom");

            entity.HasOne(d => d.CompletedByEmployee).WithMany(p => p.KitAssemblyOrder)
                .HasForeignKey(d => d.CompletedByEmployeeId)
                .HasConstraintName("FK_KitAssemblyOrder_CompletedBy");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.KitAssemblyOrder)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitAssemblyOrder_Warehouse");
        });

        modelBuilder.Entity<KitAssemblyOutput>(entity =>
        {
            entity.HasIndex(e => e.KitAssemblyOrderId, "IX_KitAssemblyOutput_OrderId");

            entity.HasOne(d => d.KitAssemblyOrder).WithMany(p => p.KitAssemblyOutput)
                .HasForeignKey(d => d.KitAssemblyOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitAssemblyOutput_Order");

            entity.HasOne(d => d.Location).WithMany(p => p.KitAssemblyOutput)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitAssemblyOutput_Location");

            entity.HasOne(d => d.OutputLot).WithMany(p => p.KitAssemblyOutput)
                .HasForeignKey(d => d.OutputLotId)
                .HasConstraintName("FK_KitAssemblyOutput_Lot");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasIndex(e => e.ParentLocationId, "IX_Location_ParentLocationId");

            entity.HasIndex(e => e.WarehouseZoneId, "IX_Location_WarehouseZoneId");

            entity.HasIndex(e => new { e.WarehouseZoneId, e.Code }, "UQ_Location_ZoneCode").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.LocationType).HasMaxLength(10);

            entity.HasOne(d => d.ParentLocation).WithMany(p => p.InverseParentLocation)
                .HasForeignKey(d => d.ParentLocationId)
                .HasConstraintName("FK_Location_Parent");

            entity.HasOne(d => d.WarehouseZone).WithMany(p => p.Location)
                .HasForeignKey(d => d.WarehouseZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Zone");
        });

        modelBuilder.Entity<LocationCapacity>(entity =>
        {
            entity.HasIndex(e => e.LocationId, "UQ_LocationCapacity_LocationId").IsUnique();

            entity.Property(e => e.MaxVolume).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.MaxWeight).HasColumnType("decimal(10, 3)");

            entity.HasOne(d => d.Location).WithOne(p => p.LocationCapacity)
                .HasForeignKey<LocationCapacity>(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationCapacity_Location");
        });

        modelBuilder.Entity<Lot>(entity =>
        {
            entity.HasIndex(e => e.ExpiryDate, "IX_Lot_ExpiryDate").HasFilter("([ExpiryDate] IS NOT NULL)");

            entity.HasIndex(e => e.ProductVariantId, "IX_Lot_ProductVariantId");

            entity.HasIndex(e => new { e.ProductVariantId, e.LotNumber }, "UQ_Lot_VariantLotNumber").IsUnique();

            entity.Property(e => e.LotNumber).HasMaxLength(50);
            entity.Property(e => e.SupplierLotNo).HasMaxLength(50);

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.Lot)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lot_Variant");

            entity.HasOne(d => d.ReceivedFromSupplier).WithMany(p => p.Lot)
                .HasForeignKey(d => d.ReceivedFromSupplierId)
                .HasConstraintName("FK_Lot_Supplier");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasIndex(e => e.Name, "UQ_Manufacturer_Name").IsUnique();

            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Numbers>(entity =>
        {
            entity.HasKey(e => e.N);

            entity.Property(e => e.N).ValueGeneratedNever();
        });

        modelBuilder.Entity<PickList>(entity =>
        {
            entity.HasIndex(e => e.SalesOrderId, "IX_PickList_SalesOrderId");

            entity.HasIndex(e => e.PickListNo, "UQ_PickList_PickListNo").IsUnique();

            entity.Property(e => e.PickListNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Pending", "DF_PickList_Status");

            entity.HasOne(d => d.AssignedToEmployee).WithMany(p => p.PickList)
                .HasForeignKey(d => d.AssignedToEmployeeId)
                .HasConstraintName("FK_PickList_AssignedTo");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.PickList)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickList_Order");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.PickList)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickList_Warehouse");
        });

        modelBuilder.Entity<PickListLine>(entity =>
        {
            entity.HasIndex(e => e.PickListId, "IX_PickListLine_PickListId");

            entity.HasOne(d => d.Location).WithMany(p => p.PickListLine)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickListLine_Location");

            entity.HasOne(d => d.Lot).WithMany(p => p.PickListLine)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_PickListLine_Lot");

            entity.HasOne(d => d.PickList).WithMany(p => p.PickListLine)
                .HasForeignKey(d => d.PickListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickListLine_PickList");

            entity.HasOne(d => d.SalesOrderLine).WithMany(p => p.PickListLine)
                .HasForeignKey(d => d.SalesOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PickListLine_OrderLine");
        });

        modelBuilder.Entity<PriceList>(entity =>
        {
            entity.HasIndex(e => e.Code, "UQ_PriceList_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Currency).WithMany(p => p.PriceList)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceList_Currency");
        });

        modelBuilder.Entity<PriceListItem>(entity =>
        {
            entity.HasIndex(e => e.PriceListId, "IX_PriceListItem_PriceListId");

            entity.HasIndex(e => new { e.PriceListId, e.ProductVariantId, e.MinQuantity }, "UQ_PriceListItem_ListVariantTier").IsUnique();

            entity.Property(e => e.MinQuantity).HasDefaultValue(1, "DF_PriceListItem_MinQuantity");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.PriceList).WithMany(p => p.PriceListItem)
                .HasForeignKey(d => d.PriceListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceListItem_PriceList");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.PriceListItem)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceListItem_Variant");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Product_CategoryId");

            entity.HasIndex(e => e.BaseSku, "UQ_Product_BaseSku").IsUnique();

            entity.Property(e => e.BaseSku).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Product_IsActive");
            entity.Property(e => e.IsPurchasable).HasDefaultValue(true, "DF_Product_IsPurchasable");
            entity.Property(e => e.IsSellable).HasDefaultValue(true, "DF_Product_IsSellable");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ProductType)
                .HasMaxLength(10)
                .HasDefaultValue("Simple", "DF_Product_ProductType");

            entity.HasOne(d => d.BaseUom).WithMany(p => p.Product)
                .HasForeignKey(d => d.BaseUomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_BaseUom");

            entity.HasOne(d => d.Brand).WithMany(p => p.Product)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_Product_Brand");

            entity.HasOne(d => d.Category).WithMany(p => p.Product)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Category");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Product)
                .HasForeignKey(d => d.ManufacturerId)
                .HasConstraintName("FK_Product_Manufacturer");
        });

        modelBuilder.Entity<ProductAttribute>(entity =>
        {
            entity.HasIndex(e => e.Name, "UQ_ProductAttribute_Name").IsUnique();

            entity.Property(e => e.DataType).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ProductAttributeValue>(entity =>
        {
            entity.HasIndex(e => new { e.ProductAttributeId, e.Value }, "UQ_ProductAttributeValue_PerAttribute").IsUnique();

            entity.Property(e => e.Value).HasMaxLength(200);

            entity.HasOne(d => d.ProductAttribute).WithMany(p => p.ProductAttributeValue)
                .HasForeignKey(d => d.ProductAttributeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductAttributeValue_Attribute");
        });

        modelBuilder.Entity<ProductBarcode>(entity =>
        {
            entity.HasIndex(e => e.ProductVariantId, "IX_ProductBarcode_ProductVariantId");

            entity.HasIndex(e => e.Barcode, "UQ_ProductBarcode_Barcode").IsUnique();

            entity.HasIndex(e => e.ProductVariantId, "UQ_ProductBarcode_OnePrimaryPerVariant")
                .IsUnique()
                .HasFilter("([IsPrimary]=(1))");

            entity.Property(e => e.Barcode).HasMaxLength(50);

            entity.HasOne(d => d.ProductVariant).WithOne(p => p.ProductBarcode)
                .HasForeignKey<ProductBarcode>(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductBarcode_Variant");

            entity.HasOne(d => d.Uom).WithMany(p => p.ProductBarcode)
                .HasForeignKey(d => d.UomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductBarcode_Uom");
        });

        modelBuilder.Entity<ProductLifecycle>(entity =>
        {
            entity.HasIndex(e => new { e.ProductId, e.ChangedUtc }, "IX_ProductLifecycle_Product_ChangedUtc").IsDescending(false, true);

            entity.Property(e => e.ChangedUtc)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_ProductLifecycle_ChangedUtc");
            entity.Property(e => e.Stage).HasMaxLength(15);

            entity.HasOne(d => d.ChangedByEmployee).WithMany(p => p.ProductLifecycle)
                .HasForeignKey(d => d.ChangedByEmployeeId)
                .HasConstraintName("FK_ProductLifecycle_ChangedBy");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductLifecycle)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductLifecycle_Product");
        });

        modelBuilder.Entity<ProductRevision>(entity =>
        {
            entity.HasIndex(e => e.ProductId, "IX_ProductRevision_ProductId");

            entity.HasIndex(e => new { e.ProductId, e.RevisionCode }, "UQ_ProductRevision_Code").IsUnique();

            entity.Property(e => e.ChangeReason).HasMaxLength(500);
            entity.Property(e => e.RevisionCode).HasMaxLength(20);

            entity.HasOne(d => d.ApprovedByEmployee).WithMany(p => p.ProductRevision)
                .HasForeignKey(d => d.ApprovedByEmployeeId)
                .HasConstraintName("FK_ProductRevision_ApprovedBy");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductRevision)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductRevision_Product");
        });

        modelBuilder.Entity<ProductSupplier>(entity =>
        {
            entity.HasIndex(e => e.ProductVariantId, "IX_ProductSupplier_ProductVariantId");

            entity.HasIndex(e => e.SupplierId, "IX_ProductSupplier_SupplierId");

            entity.HasIndex(e => e.ProductVariantId, "UQ_ProductSupplier_OnePreferredPerProduct")
                .IsUnique()
                .HasFilter("([IsPreferred]=(1))");

            entity.HasIndex(e => new { e.ProductVariantId, e.SupplierId }, "UQ_ProductSupplier_VariantSupplier").IsUnique();

            entity.Property(e => e.LastPurchasePrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SupplierSku).HasMaxLength(50);

            entity.HasOne(d => d.ProductVariant).WithOne(p => p.ProductSupplier)
                .HasForeignKey<ProductSupplier>(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSupplier_Variant");

            entity.HasOne(d => d.Supplier).WithMany(p => p.ProductSupplier)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSupplier_Supplier");
        });

        modelBuilder.Entity<ProductVariant>(entity =>
        {
            entity.HasIndex(e => e.ProductId, "IX_ProductVariant_ProductId");

            entity.HasIndex(e => e.ProductId, "UQ_ProductVariant_OneDefaultPerProduct")
                .IsUnique()
                .HasFilter("([IsDefault]=(1))");

            entity.HasIndex(e => e.VariantSku, "UQ_ProductVariant_VariantSku").IsUnique();

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ProductVariant_IsActive");
            entity.Property(e => e.VariantSku).HasMaxLength(50);
            entity.Property(e => e.Volume).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Weight).HasColumnType("decimal(10, 3)");

            entity.HasOne(d => d.Product).WithOne(p => p.ProductVariant)
                .HasForeignKey<ProductVariant>(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariant_Product");

            entity.HasMany(d => d.ProductAttributeValue).WithMany(p => p.ProductVariant)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductVariantAttributeValue",
                    r => r.HasOne<ProductAttributeValue>().WithMany()
                        .HasForeignKey("ProductAttributeValueId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PVAV_AttributeValue"),
                    l => l.HasOne<ProductVariant>().WithMany()
                        .HasForeignKey("ProductVariantId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PVAV_Variant"),
                    j =>
                    {
                        j.HasKey("ProductVariantId", "ProductAttributeValueId");
                        j.HasIndex(new[] { "ProductAttributeValueId" }, "IX_PVAV_AttributeValueId");
                    });
        });

        modelBuilder.Entity<PurchaseInvoice>(entity =>
        {
            entity.HasIndex(e => e.PurchaseOrderId, "IX_PurchaseInvoice_PurchaseOrderId");

            entity.HasIndex(e => new { e.SupplierId, e.InvoiceNo }, "UQ_PurchaseInvoice_SupplierInvoiceNo").IsUnique();

            entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Pending", "DF_PurchaseInvoice_Status");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseInvoice)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoice_Order");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseInvoice)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoice_Supplier");
        });

        modelBuilder.Entity<PurchaseInvoiceLine>(entity =>
        {
            entity.HasIndex(e => e.GoodsReceiptLineId, "IX_PurchaseInvoiceLine_GoodsReceiptLineId");

            entity.HasIndex(e => e.PurchaseInvoiceId, "IX_PurchaseInvoiceLine_PurchaseInvoiceId");

            entity.HasIndex(e => e.PurchaseOrderLineId, "IX_PurchaseInvoiceLine_PurchaseOrderLineId");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.GoodsReceiptLine).WithMany(p => p.PurchaseInvoiceLine)
                .HasForeignKey(d => d.GoodsReceiptLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoiceLine_ReceiptLine");

            entity.HasOne(d => d.PurchaseInvoice).WithMany(p => p.PurchaseInvoiceLine)
                .HasForeignKey(d => d.PurchaseInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoiceLine_Invoice");

            entity.HasOne(d => d.PurchaseOrderLine).WithMany(p => p.PurchaseInvoiceLine)
                .HasForeignKey(d => d.PurchaseOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoiceLine_OrderLine");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasIndex(e => e.SupplierId, "IX_PurchaseOrder_SupplierId");

            entity.HasIndex(e => e.PoNo, "UQ_PurchaseOrder_PoNo").IsUnique();

            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.OrderDateUtc)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_PurchaseOrder_OrderDateUtc");
            entity.Property(e => e.PoNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Draft", "DF_PurchaseOrder_Status");

            entity.HasOne(d => d.Currency).WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_Currency");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_Supplier");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_Warehouse");
        });

        modelBuilder.Entity<PurchaseOrderApproval>(entity =>
        {
            entity.HasIndex(e => e.PurchaseOrderId, "IX_PurchaseOrderApproval_PurchaseOrderId");

            entity.HasIndex(e => new { e.PurchaseOrderId, e.StepOrder }, "UQ_PurchaseOrderApproval_OrderStep").IsUnique();

            entity.Property(e => e.ActionUtc).HasPrecision(3);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("Pending", "DF_PurchaseOrderApproval_Status");

            entity.HasOne(d => d.ApproverEmployee).WithMany(p => p.PurchaseOrderApproval)
                .HasForeignKey(d => d.ApproverEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderApproval_Approver");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseOrderApproval)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderApproval_Order");
        });

        modelBuilder.Entity<PurchaseOrderLine>(entity =>
        {
            entity.HasIndex(e => e.PurchaseOrderId, "IX_PurchaseOrderLine_PurchaseOrderId");

            entity.Property(e => e.LineTotal)
                .HasComputedColumnSql("([Quantity]*[UnitCost])", true)
                .HasColumnType("decimal(29, 4)");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.PurchaseOrderLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderLine_Variant");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseOrderLine)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderLine_Order");

            entity.HasOne(d => d.TaxCode).WithMany(p => p.PurchaseOrderLine)
                .HasForeignKey(d => d.TaxCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderLine_TaxCode");
        });

        modelBuilder.Entity<PurchaseRequisition>(entity =>
        {
            entity.HasIndex(e => e.RequisitionNo, "UQ_PurchaseRequisition_No").IsUnique();

            entity.Property(e => e.RequisitionNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Draft", "DF_PurchaseRequisition_Status");

            entity.HasOne(d => d.RequestedByEmployee).WithMany(p => p.PurchaseRequisition)
                .HasForeignKey(d => d.RequestedByEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseRequisition_RequestedBy");
        });

        modelBuilder.Entity<PurchaseRequisitionLine>(entity =>
        {
            entity.HasIndex(e => e.PurchaseRequisitionId, "IX_PurchaseRequisitionLine_RequisitionId");

            entity.Property(e => e.EstimatedPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.PurchaseRequisitionLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseRequisitionLine_Variant");

            entity.HasOne(d => d.PurchaseRequisition).WithMany(p => p.PurchaseRequisitionLine)
                .HasForeignKey(d => d.PurchaseRequisitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseRequisitionLine_Requisition");
        });

        modelBuilder.Entity<PurchaseReturn>(entity =>
        {
            entity.HasIndex(e => e.ReturnNo, "UQ_PurchaseReturn_ReturnNo").IsUnique();

            entity.Property(e => e.ReturnNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Draft", "DF_PurchaseReturn_Status");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseReturn)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturn_Order");

            entity.HasOne(d => d.Reason).WithMany(p => p.PurchaseReturn)
                .HasForeignKey(d => d.ReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturn_Reason");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseReturn)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturn_Supplier");
        });

        modelBuilder.Entity<PurchaseReturnLine>(entity =>
        {
            entity.HasIndex(e => e.PurchaseReturnId, "IX_PurchaseReturnLine_PurchaseReturnId");

            entity.HasOne(d => d.Lot).WithMany(p => p.PurchaseReturnLine)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_PurchaseReturnLine_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.PurchaseReturnLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturnLine_Variant");

            entity.HasOne(d => d.PurchaseReturn).WithMany(p => p.PurchaseReturnLine)
                .HasForeignKey(d => d.PurchaseReturnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturnLine_Return");
        });

        modelBuilder.Entity<RequestForQuotation>(entity =>
        {
            entity.HasIndex(e => e.RfqNo, "UQ_RequestForQuotation_No").IsUnique();

            entity.Property(e => e.DueUtc).HasPrecision(3);
            entity.Property(e => e.IssuedUtc).HasPrecision(3);
            entity.Property(e => e.RfqNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Draft", "DF_RFQ_Status");
        });

        modelBuilder.Entity<Rfqline>(entity =>
        {
            entity.ToTable("RFQLine");

            entity.HasIndex(e => e.RfqId, "IX_RFQLine_RfqId");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.Rfqline)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFQLine_Variant");

            entity.HasOne(d => d.Rfq).WithMany(p => p.Rfqline)
                .HasForeignKey(d => d.RfqId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFQLine_Rfq");
        });

        modelBuilder.Entity<SafetyStockPolicy>(entity =>
        {
            entity.HasIndex(e => new { e.ProductVariantId, e.WarehouseId }, "UQ_SafetyStockPolicy_VariantWarehouse").IsUnique();

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.SafetyStockPolicy)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SafetyStockPolicy_Variant");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.SafetyStockPolicy)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SafetyStockPolicy_Warehouse");
        });

        modelBuilder.Entity<SalesInvoice>(entity =>
        {
            entity.HasIndex(e => e.SalesOrderId, "IX_SalesInvoice_SalesOrderId");

            entity.HasIndex(e => e.InvoiceNo, "UQ_SalesInvoice_InvoiceNo").IsUnique();

            entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Pending", "DF_SalesInvoice_Status");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesInvoice)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesInvoice_Customer");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesInvoice)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesInvoice_Order");
        });

        modelBuilder.Entity<SalesInvoiceLine>(entity =>
        {
            entity.HasIndex(e => e.SalesInvoiceId, "IX_SalesInvoiceLine_SalesInvoiceId");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.SalesInvoice).WithMany(p => p.SalesInvoiceLine)
                .HasForeignKey(d => d.SalesInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesInvoiceLine_Invoice");

            entity.HasOne(d => d.SalesOrderLine).WithMany(p => p.SalesInvoiceLine)
                .HasForeignKey(d => d.SalesOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesInvoiceLine_OrderLine");
        });

        modelBuilder.Entity<SalesOrder>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_SalesOrder_CustomerId");

            entity.HasIndex(e => e.OrderNo, "UQ_SalesOrder_OrderNo").IsUnique();

            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.OrderDateUtc)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_SalesOrder_OrderDateUtc");
            entity.Property(e => e.OrderNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Draft", "DF_SalesOrder_Status");

            entity.HasOne(d => d.Currency).WithMany(p => p.SalesOrder)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrder_Currency");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesOrder)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrder_Customer");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.SalesOrder)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrder_Warehouse");
        });

        modelBuilder.Entity<SalesOrderApproval>(entity =>
        {
            entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderApproval_SalesOrderId");

            entity.Property(e => e.ActionUtc).HasPrecision(3);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("Pending", "DF_SalesOrderApproval_Status");

            entity.HasOne(d => d.ApproverEmployee).WithMany(p => p.SalesOrderApproval)
                .HasForeignKey(d => d.ApproverEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderApproval_Approver");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderApproval)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderApproval_Order");
        });

        modelBuilder.Entity<SalesOrderLine>(entity =>
        {
            entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderLine_SalesOrderId");

            entity.Property(e => e.LineTotal)
                .HasComputedColumnSql("([Quantity]*[UnitPrice])", true)
                .HasColumnType("decimal(29, 4)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.SalesOrderLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderLine_Variant");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderLine)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderLine_Order");

            entity.HasOne(d => d.TaxCode).WithMany(p => p.SalesOrderLine)
                .HasForeignKey(d => d.TaxCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderLine_TaxCode");
        });

        modelBuilder.Entity<SalesQuote>(entity =>
        {
            entity.HasIndex(e => e.QuoteNo, "UQ_SalesQuote_QuoteNo").IsUnique();

            entity.Property(e => e.QuoteNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Draft", "DF_SalesQuote_Status");
            entity.Property(e => e.ValidUntilUtc).HasPrecision(3);

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesQuote)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuote_Customer");
        });

        modelBuilder.Entity<SalesQuoteLine>(entity =>
        {
            entity.HasIndex(e => e.SalesQuoteId, "IX_SalesQuoteLine_SalesQuoteId");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.SalesQuoteLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteLine_Variant");

            entity.HasOne(d => d.SalesQuote).WithMany(p => p.SalesQuoteLine)
                .HasForeignKey(d => d.SalesQuoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteLine_Quote");
        });

        modelBuilder.Entity<SalesReturn>(entity =>
        {
            entity.HasIndex(e => e.RmaNo, "UQ_SalesReturn_RmaNo").IsUnique();

            entity.Property(e => e.RmaNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Requested", "DF_SalesReturn_Status");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesReturn)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturn_Customer");

            entity.HasOne(d => d.Reason).WithMany(p => p.SalesReturn)
                .HasForeignKey(d => d.ReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturn_Reason");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesReturn)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturn_Order");
        });

        modelBuilder.Entity<SalesReturnLine>(entity =>
        {
            entity.HasIndex(e => e.SalesReturnId, "IX_SalesReturnLine_SalesReturnId");

            entity.Property(e => e.Condition).HasMaxLength(10);

            entity.HasOne(d => d.Lot).WithMany(p => p.SalesReturnLine)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_SalesReturnLine_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.SalesReturnLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturnLine_Variant");

            entity.HasOne(d => d.SalesReturn).WithMany(p => p.SalesReturnLine)
                .HasForeignKey(d => d.SalesReturnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturnLine_Return");
        });

        modelBuilder.Entity<SerialNumber>(entity =>
        {
            entity.HasIndex(e => e.ProductVariantId, "IX_SerialNumber_ProductVariantId");

            entity.HasIndex(e => e.SerialNo, "UQ_SerialNumber_SerialNo").IsUnique();

            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("InStock", "DF_SerialNumber_Status");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.SerialNumber)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialNumber_Variant");
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.HasIndex(e => e.SalesOrderId, "IX_Shipment_SalesOrderId");

            entity.HasIndex(e => e.ShipmentNo, "UQ_Shipment_ShipmentNo").IsUnique();

            entity.Property(e => e.ShipmentNo).HasMaxLength(30);
            entity.Property(e => e.ShippedUtc).HasPrecision(3);
            entity.Property(e => e.TrackingNo).HasMaxLength(50);

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.Shipment)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_Order");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Shipment)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_Warehouse");
        });

        modelBuilder.Entity<ShipmentLine>(entity =>
        {
            entity.HasIndex(e => e.SalesOrderLineId, "IX_ShipmentLine_SalesOrderLineId");

            entity.HasIndex(e => e.ShipmentId, "IX_ShipmentLine_ShipmentId");

            entity.HasOne(d => d.Lot).WithMany(p => p.ShipmentLine)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_ShipmentLine_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.ShipmentLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShipmentLine_Variant");

            entity.HasOne(d => d.SalesOrderLine).WithMany(p => p.ShipmentLine)
                .HasForeignKey(d => d.SalesOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShipmentLine_OrderLine");

            entity.HasOne(d => d.Shipment).WithMany(p => p.ShipmentLine)
                .HasForeignKey(d => d.ShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShipmentLine_Shipment");
        });

        modelBuilder.Entity<StockAdjustment>(entity =>
        {
            entity.HasIndex(e => e.AdjustmentNo, "UQ_StockAdjustment_AdjustmentNo").IsUnique();

            entity.Property(e => e.AdjustmentNo).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("Pending", "DF_StockAdjustment_Status");

            entity.HasOne(d => d.ApprovedByEmployee).WithMany(p => p.StockAdjustment)
                .HasForeignKey(d => d.ApprovedByEmployeeId)
                .HasConstraintName("FK_StockAdjustment_ApprovedBy");

            entity.HasOne(d => d.Reason).WithMany(p => p.StockAdjustment)
                .HasForeignKey(d => d.ReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustment_Reason");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockAdjustment)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustment_Warehouse");
        });

        modelBuilder.Entity<StockAdjustmentLine>(entity =>
        {
            entity.HasIndex(e => e.StockAdjustmentId, "IX_StockAdjustmentLine_StockAdjustmentId");

            entity.Property(e => e.Direction).HasMaxLength(3);

            entity.HasOne(d => d.Location).WithMany(p => p.StockAdjustmentLine)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentLine_Location");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockAdjustmentLine)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_StockAdjustmentLine_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.StockAdjustmentLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentLine_Variant");

            entity.HasOne(d => d.StockAdjustment).WithMany(p => p.StockAdjustmentLine)
                .HasForeignKey(d => d.StockAdjustmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentLine_Adjustment");
        });

        modelBuilder.Entity<StockAllocation>(entity =>
        {
            entity.HasIndex(e => e.StockReservationId, "IX_StockAllocation_StockReservationId");

            entity.Property(e => e.AllocatedUtc)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_StockAllocation_AllocatedUtc");

            entity.HasOne(d => d.Location).WithMany(p => p.StockAllocation)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAllocation_Location");

            entity.HasOne(d => d.StockReservation).WithMany(p => p.StockAllocation)
                .HasForeignKey(d => d.StockReservationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAllocation_Reservation");
        });

        modelBuilder.Entity<StockCount>(entity =>
        {
            entity.HasIndex(e => e.CountNo, "UQ_StockCount_CountNo").IsUnique();

            entity.Property(e => e.CompletedUtc).HasPrecision(3);
            entity.Property(e => e.CountNo).HasMaxLength(30);
            entity.Property(e => e.CountType).HasMaxLength(10);
            entity.Property(e => e.StartedUtc).HasPrecision(3);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Draft", "DF_StockCount_Status");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockCount)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCount_Warehouse");
        });

        modelBuilder.Entity<StockCountLine>(entity =>
        {
            entity.HasIndex(e => e.StockCountId, "IX_StockCountLine_StockCountId");

            entity.HasIndex(e => new { e.StockCountId, e.ProductVariantId, e.LocationId }, "UQ_StockCountLine_CountVariantLocation").IsUnique();

            entity.Property(e => e.VarianceQty).HasComputedColumnSql("([CountedQty]-[SystemQty])", true);

            entity.HasOne(d => d.CountedByEmployee).WithMany(p => p.StockCountLine)
                .HasForeignKey(d => d.CountedByEmployeeId)
                .HasConstraintName("FK_StockCountLine_CountedBy");

            entity.HasOne(d => d.Location).WithMany(p => p.StockCountLine)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCountLine_Location");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockCountLine)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_StockCountLine_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.StockCountLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCountLine_Variant");

            entity.HasOne(d => d.StockCount).WithMany(p => p.StockCountLine)
                .HasForeignKey(d => d.StockCountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCountLine_Count");
        });

        modelBuilder.Entity<StockMovement>(entity =>
        {
            entity.HasIndex(e => e.ProductVariantId, "IX_StockMovement_ProductVariantId");

            entity.HasIndex(e => new { e.ProductVariantId, e.MovementDateUtc }, "IX_StockMovement_Product_MovementDate").IsDescending(false, true);

            entity.HasIndex(e => new { e.ReferenceType, e.ReferenceId }, "IX_StockMovement_Reference");

            entity.HasIndex(e => e.MovementNo, "UQ_StockMovement_MovementNo").IsUnique();

            entity.Property(e => e.MovementDateUtc)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_StockMovement_MovementDateUtc");
            entity.Property(e => e.MovementNo).HasMaxLength(30);
            entity.Property(e => e.MovementType).HasMaxLength(15);
            entity.Property(e => e.ReferenceType).HasMaxLength(20);

            entity.HasOne(d => d.CreatedByEmployee).WithMany(p => p.StockMovement)
                .HasForeignKey(d => d.CreatedByEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockMovement_CreatedBy");

            entity.HasOne(d => d.Location).WithMany(p => p.StockMovement)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockMovement_Location");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockMovement)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_StockMovement_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.StockMovement)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockMovement_Variant");

            entity.HasOne(d => d.Reason).WithMany(p => p.StockMovement)
                .HasForeignKey(d => d.ReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockMovement_Reason");

            entity.HasOne(d => d.Serial).WithMany(p => p.StockMovement)
                .HasForeignKey(d => d.SerialId)
                .HasConstraintName("FK_StockMovement_Serial");
        });

        modelBuilder.Entity<StockMovementReason>(entity =>
        {
            entity.HasIndex(e => e.Code, "UQ_StockMovementReason_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.MovementCategory).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<StockReservation>(entity =>
        {
            entity.HasIndex(e => e.ProductVariantId, "IX_StockReservation_ProductVariantId");

            entity.HasIndex(e => e.SalesOrderLineId, "IX_StockReservation_SalesOrderLineId");

            entity.Property(e => e.ExpiresUtc).HasPrecision(3);
            entity.Property(e => e.ReservedUtc)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_StockReservation_ReservedUtc");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("Active", "DF_StockReservation_Status");

            entity.HasOne(d => d.Location).WithMany(p => p.StockReservation)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockReservation_Location");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.StockReservation)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockReservation_Variant");

            entity.HasOne(d => d.SalesOrderLine).WithMany(p => p.StockReservation)
                .HasForeignKey(d => d.SalesOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockReservation_SalesOrderLine");
        });

        modelBuilder.Entity<StockTransfer>(entity =>
        {
            entity.HasIndex(e => e.TransferNo, "UQ_StockTransfer_TransferNo").IsUnique();

            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("Draft", "DF_StockTransfer_Status");
            entity.Property(e => e.TransferNo).HasMaxLength(30);

            entity.HasOne(d => d.FromWarehouse).WithMany(p => p.StockTransferFromWarehouse)
                .HasForeignKey(d => d.FromWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfer_FromWarehouse");

            entity.HasOne(d => d.RequestedByEmployee).WithMany(p => p.StockTransfer)
                .HasForeignKey(d => d.RequestedByEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfer_RequestedBy");

            entity.HasOne(d => d.ToWarehouse).WithMany(p => p.StockTransferToWarehouse)
                .HasForeignKey(d => d.ToWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfer_ToWarehouse");
        });

        modelBuilder.Entity<StockTransferLine>(entity =>
        {
            entity.HasIndex(e => e.StockTransferId, "IX_StockTransferLine_StockTransferId");

            entity.HasIndex(e => new { e.StockTransferId, e.ProductVariantId }, "UQ_StockTransferLine_TransferVariant").IsUnique();

            entity.HasOne(d => d.Lot).WithMany(p => p.StockTransferLine)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_StockTransferLine_Lot");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.StockTransferLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransferLine_Variant");

            entity.HasOne(d => d.StockTransfer).WithMany(p => p.StockTransferLine)
                .HasForeignKey(d => d.StockTransferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransferLine_Transfer");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasIndex(e => e.TaxNumber, "UQ_Supplier_TaxNumber").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PaymentTermDays).HasDefaultValue((short)30, "DF_Supplier_PaymentTermDays");
            entity.Property(e => e.TaxNumber).HasMaxLength(20);

            entity.HasOne(d => d.DefaultCurrency).WithMany(p => p.Supplier)
                .HasForeignKey(d => d.DefaultCurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Supplier_DefaultCurrency");
        });

        modelBuilder.Entity<SupplierQuote>(entity =>
        {
            entity.HasIndex(e => new { e.RfqId, e.SupplierId }, "UQ_SupplierQuote_RfqSupplier").IsUnique();

            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("Submitted", "DF_SupplierQuote_Status");
            entity.Property(e => e.ValidUntilUtc).HasPrecision(3);

            entity.HasOne(d => d.Currency).WithMany(p => p.SupplierQuote)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuote_Currency");

            entity.HasOne(d => d.Rfq).WithMany(p => p.SupplierQuote)
                .HasForeignKey(d => d.RfqId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuote_Rfq");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierQuote)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuote_Supplier");
        });

        modelBuilder.Entity<SupplierQuoteLine>(entity =>
        {
            entity.HasIndex(e => e.RfqLineId, "IX_SupplierQuoteLine_RfqLineId");

            entity.HasIndex(e => new { e.SupplierQuoteId, e.RfqLineId }, "UQ_SupplierQuoteLine_QuoteRfqLine").IsUnique();

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductVariant).WithMany(p => p.SupplierQuoteLine)
                .HasForeignKey(d => d.ProductVariantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuoteLine_Variant");

            entity.HasOne(d => d.RfqLine).WithMany(p => p.SupplierQuoteLine)
                .HasForeignKey(d => d.RfqLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuoteLine_RfqLine");

            entity.HasOne(d => d.SupplierQuote).WithMany(p => p.SupplierQuoteLine)
                .HasForeignKey(d => d.SupplierQuoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuoteLine_Quote");
        });

        modelBuilder.Entity<TaxCode>(entity =>
        {
            entity.HasIndex(e => e.Code, "UQ_TaxCode_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.RatePercent).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<UnitOfMeasure>(entity =>
        {
            entity.HasIndex(e => e.Code, "UQ_UnitOfMeasure_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Uomclass)
                .HasMaxLength(10)
                .HasColumnName("UOMClass");
        });

        modelBuilder.Entity<UnitOfMeasureConversion>(entity =>
        {
            entity.HasIndex(e => new { e.FromUomId, e.ToUomId }, "UQ_UOMConversion_Global")
                .IsUnique()
                .HasFilter("([ProductId] IS NULL)");

            entity.HasIndex(e => new { e.ProductId, e.FromUomId, e.ToUomId }, "UQ_UOMConversion_ProductSpecific")
                .IsUnique()
                .HasFilter("([ProductId] IS NOT NULL)");

            entity.Property(e => e.ConversionFactor).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.FromUom).WithMany(p => p.UnitOfMeasureConversionFromUom)
                .HasForeignKey(d => d.FromUomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UOMConversion_FromUom");

            entity.HasOne(d => d.Product).WithMany(p => p.UnitOfMeasureConversion)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_UOMConversion_Product");

            entity.HasOne(d => d.ToUom).WithMany(p => p.UnitOfMeasureConversionToUom)
                .HasForeignKey(d => d.ToUomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UOMConversion_ToUom");
        });

        modelBuilder.Entity<VwAnlamliVeriTesti>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ANLAMLI_VERI_TESTI");

            entity.Property(e => e.ToplamCiro).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.UrunAdi).HasMaxLength(200);
        });

        modelBuilder.Entity<VwBostablokontrolu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BOSTABLOKONTROLU");

            entity.Property(e => e.BosTablo).HasMaxLength(128);
        });

        modelBuilder.Entity<VwIliskiselbutunlukkontrolleri>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ILISKISELBUTUNLUKKONTROLLERI");

            entity.Property(e => e.Kontrol)
                .HasMaxLength(23)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwKritiktablolarinSatirSayilari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ KRITIKTABLOLARIN_SATIR_SAYILARI");

            entity.Property(e => e.Tablo)
                .HasMaxLength(19)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSorgu5TablolardakiSatirSayisi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Sorgu5_tablolardakiSatirSayisi");

            entity.Property(e => e.Tablo).HasMaxLength(128);
        });

        modelBuilder.Entity<VwSorgu6VeriButunluguFkCheckIhlali>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Sorgu6_VeriButunluguFK_CHECK_ihlali");

            entity.Property(e => e.Kisit).HasMaxLength(128);
            entity.Property(e => e.Tablo).HasMaxLength(128);
            entity.Property(e => e.Tip)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_Warehouse_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.Code }, "UQ_Warehouse_CompanyCode").IsUnique();

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.Company).WithMany(p => p.Warehouse)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Warehouse_Company");
        });

        modelBuilder.Entity<WarehouseZone>(entity =>
        {
            entity.HasIndex(e => e.WarehouseId, "IX_WarehouseZone_WarehouseId");

            entity.HasIndex(e => new { e.WarehouseId, e.Code }, "UQ_WarehouseZone_WarehouseCode").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ZoneType).HasMaxLength(15);

            entity.HasOne(d => d.Warehouse).WithMany(p => p.WarehouseZone)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseZone_Warehouse");
        });

        modelBuilder.Entity<ZzBillOfMaterialLineYedek>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_BillOfMaterialLine_Yedek");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ScrapPercent).HasColumnType("decimal(5, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
