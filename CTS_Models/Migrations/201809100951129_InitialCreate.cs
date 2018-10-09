namespace CTS_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.BeltAnalysis",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            AnalysisID = c.String(nullable: false, maxLength: 255),
            //            AnalysisTimeStamp = c.DateTime(nullable: false),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            Comment = c.String(maxLength: 255),
            //            OperatorName = c.String(maxLength: 255),
            //            IsValid = c.Boolean(nullable: false),
            //            AshAvg = c.Single(),
            //            AshMax = c.Single(),
            //            SulfurAvg = c.Single(),
            //            SulfurMax = c.Single(),
            //            MoistureAvg = c.Single(),
            //            MoistureMax = c.Single(),
            //            VolatileMatter = c.Single(),
            //            Caloricity = c.Single(),
            //            CaloricityMax = c.Single(),
            //            RockPerc = c.Single(),
            //            SmallFractPerc = c.Single(),
            //            xValue = c.Single(),
            //            yValue = c.Single(),
            //            InheritedFrom = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.BeltScales",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 255),
            //            NameEng = c.String(),
            //            LocationID = c.String(maxLength: 255),
            //            FromInnerDestID = c.Int(),
            //            ToInnerDestID = c.Int(),
            //            NameKZ = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.InnerDestinations", t => t.FromInnerDestID)
            //    .ForeignKey("dbo.Locations", t => t.LocationID)
            //    .ForeignKey("dbo.InnerDestinations", t => t.ToInnerDestID)
            //    .Index(t => t.LocationID)
            //    .Index(t => t.FromInnerDestID)
            //    .Index(t => t.ToInnerDestID);
            
            //CreateTable(
            //    "dbo.InnerDestinations",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 255),
            //            NameEng = c.String(),
            //            LocationID = c.String(maxLength: 255),
            //            NameKZ = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Locations", t => t.LocationID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "dbo.Locations",
            //    c => new
            //        {
            //            ID = c.String(nullable: false, maxLength: 255),
            //            LocationName = c.String(maxLength: 255),
            //            LocationNameEng = c.String(maxLength: 255),
            //            DomainName = c.String(maxLength: 255),
            //            LocationNameKZ = c.String(maxLength: 255),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.BoilerConsNorms",
            //    c => new
            //        {
            //            ID = c.String(nullable: false, maxLength: 255),
            //            ConsNorm = c.Single(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Locations", t => t.ID)
            //    .Index(t => t.ID);
            
            //CreateTable(
            //    "dbo.BeltTransfers",
            //    c => new
            //        {
            //            ID = c.String(nullable: false, maxLength: 128),
            //            LotName = c.String(maxLength: 255),
            //            LotQuantity = c.Single(),
            //            TotalQuantity = c.Double(),
            //            Comment = c.String(maxLength: 255),
            //            OperatorName = c.String(maxLength: 255),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            TransferTimeStamp = c.DateTime(nullable: false),
            //            BeltScaleID = c.Int(),
            //            IsValid = c.Boolean(nullable: false),
            //            ItemID = c.Int(),
            //            BeltAnalysisID = c.Int(),
            //            Status = c.Int(nullable: false),
            //            ApprovedBy = c.String(),
            //            InheritedFrom = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.BeltAnalysis", t => t.BeltAnalysisID)
            //    .ForeignKey("dbo.BeltScales", t => t.BeltScaleID)
            //    .ForeignKey("dbo.Items", t => t.ItemID)
            //    .Index(t => t.BeltScaleID)
            //    .Index(t => t.ItemID)
            //    .Index(t => t.BeltAnalysisID);
            
            //CreateTable(
            //    "dbo.Items",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 255),
            //            NameEng = c.String(),
            //            LocationID = c.String(maxLength: 255),
            //            Grade = c.String(),
            //            NameKZ = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Locations", t => t.LocationID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "dbo.LocalPlan",
            //    c => new
            //        {
            //            Plan = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            LocationID = c.String(),
            //            Date = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Plan);
            
            //CreateTable(
            //    "dbo.LocalPlanB",
            //    c => new
            //        {
            //            Plan = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Date = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Plan);
            
            //CreateTable(
            //    "dbo.LocalPlanBWithLocationID",
            //    c => new
            //        {
            //            Plan = c.Int(nullable: false, identity: true),
            //            LocationID = c.String(),
            //            Date = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Plan);
            
            //CreateTable(
            //    "dbo.LocalPlanWithLocationID",
            //    c => new
            //        {
            //            Plan = c.Int(nullable: false, identity: true),
            //            LocationID = c.String(),
            //            Date = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Plan);
            
            //CreateTable(
            //    "dbo.LocalStaff",
            //    c => new
            //        {
            //            CNT = c.String(nullable: false, maxLength: 128),
            //            Date = c.DateTime(nullable: false),
            //            ShopID = c.Int(nullable: false),
            //            LocationID = c.String(),
            //        })
            //    .PrimaryKey(t => t.CNT);
            
            //CreateTable(
            //    "dbo.OrcalePlanWithShop_ID",
            //    c => new
            //        {
            //            Plan = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Shop_ID = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            TransferTimeStamp = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Plan);
            
            //CreateTable(
            //    "dbo.OracleStaff",
            //    c => new
            //        {
            //            Cnt = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Date = c.DateTime(nullable: false),
            //            Shop_ID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Cnt);
            
            //CreateTable(
            //    "dbo.OraclePlanB",
            //    c => new
            //        {
            //            Plan = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            TransferTimeStamp = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Plan);
            
            //CreateTable(
            //    "dbo.RockUtils",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 255),
            //            NameEng = c.String(),
            //            LocationID = c.String(maxLength: 255),
            //            NameKZ = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Locations", t => t.LocationID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "dbo.RockUtilTransfers",
            //    c => new
            //        {
            //            ID = c.String(nullable: false, maxLength: 128),
            //            LotQuantity = c.Single(),
            //            Comment = c.String(maxLength: 255),
            //            OperatorName = c.String(maxLength: 255),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            TransferTimeStamp = c.DateTime(nullable: false),
            //            RockUtilID = c.Int(),
            //            IsValid = c.Boolean(nullable: false),
            //            Status = c.Int(nullable: false),
            //            ApprovedBy = c.String(),
            //            InheritedFrom = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.RockUtils", t => t.RockUtilID)
            //    .Index(t => t.RockUtilID);
            
            //CreateTable(
            //    "dbo.SkipAnalysis",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            AnalysisID = c.String(nullable: false, maxLength: 255),
            //            AnalysisTimeStamp = c.DateTime(nullable: false),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            Comment = c.String(maxLength: 255),
            //            OperatorName = c.String(maxLength: 255),
            //            IsValid = c.Boolean(nullable: false),
            //            AshAvg = c.Single(),
            //            AshMax = c.Single(),
            //            SulfurAvg = c.Single(),
            //            SulfurMax = c.Single(),
            //            MoistureAvg = c.Single(),
            //            MoistureMax = c.Single(),
            //            VolatileMatter = c.Single(),
            //            Caloricity = c.Single(),
            //            CaloricityMax = c.Single(),
            //            RockPerc = c.Single(),
            //            SmallFractPerc = c.Single(),
            //            xValue = c.Single(),
            //            yValue = c.Single(),
            //            InheritedFrom = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Skips",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false),
            //            NameEng = c.String(maxLength: 255),
            //            Name = c.String(),
            //            LocationID = c.String(maxLength: 255),
            //            Weight = c.Single(nullable: false),
            //            NameKZ = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Locations", t => t.LocationID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "dbo.SkipTransfers",
            //    c => new
            //        {
            //            ID = c.String(nullable: false, maxLength: 128),
            //            LiftingID = c.String(nullable: false, maxLength: 255),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            TransferTimeStamp = c.DateTime(nullable: false),
            //            Comment = c.String(maxLength: 255),
            //            OperatorName = c.String(maxLength: 255),
            //            SkipID = c.Int(),
            //            IsValid = c.Boolean(nullable: false),
            //            SkipAnalysisID = c.Int(),
            //            SkipWeight = c.Single(nullable: false),
            //            Status = c.Int(nullable: false),
            //            ApprovedBy = c.String(),
            //            InheritedFrom = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.SkipAnalysis", t => t.SkipAnalysisID)
            //    .ForeignKey("dbo.Skips", t => t.SkipID)
            //    .Index(t => t.SkipID)
            //    .Index(t => t.SkipAnalysisID);
            
            //CreateTable(
            //    "dbo.SkipWeights",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            SkipID = c.Int(nullable: false),
            //            Weight = c.Single(nullable: false),
            //            ValidFrom = c.DateTime(nullable: false),
            //            OrderNo = c.String(maxLength: 255),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            OperatorName = c.String(maxLength: 255),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Skips", t => t.SkipID, cascadeDelete: true)
            //    .Index(t => t.SkipID);
            
            //CreateTable(
            //    "dbo.UserRoles",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            SystemName = c.String(nullable: false),
            //            DomainRoleName = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.VehiScales",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 255),
            //            NameEng = c.String(),
            //            LocationID = c.String(maxLength: 255),
            //            NameKZ = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Locations", t => t.LocationID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "dbo.VehiTransfers",
            //    c => new
            //        {
            //            ID = c.String(nullable: false, maxLength: 128),
            //            VehiScaleID = c.Int(),
            //            FromDestID = c.String(maxLength: 255),
            //            ToDest = c.String(maxLength: 255),
            //            LotName = c.String(nullable: false, maxLength: 255),
            //            Brutto = c.Single(nullable: false),
            //            Comment = c.String(maxLength: 255),
            //            OperatorName = c.String(maxLength: 255),
            //            Tare = c.Single(nullable: false),
            //            ItemID = c.Int(),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            TransferTimeStamp = c.DateTime(nullable: false),
            //            IsValid = c.Boolean(nullable: false),
            //            Status = c.Int(nullable: false),
            //            ApprovedBy = c.String(),
            //            InheritedFrom = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.VehiScales", t => t.VehiScaleID)
            //    .ForeignKey("dbo.Locations", t => t.FromDestID)
            //    .ForeignKey("dbo.Items", t => t.ItemID)
            //    .Index(t => t.VehiScaleID)
            //    .Index(t => t.FromDestID)
            //    .Index(t => t.ItemID);
            
            //CreateTable(
            //    "dbo.WagonAnalysis",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            AnalysisID = c.String(nullable: false, maxLength: 255),
            //            AnalysisTimeStamp = c.DateTime(nullable: false),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            Comment = c.String(maxLength: 255),
            //            OperatorName = c.String(maxLength: 255),
            //            IsValid = c.Boolean(nullable: false),
            //            AshAvg = c.Single(),
            //            AshMax = c.Single(),
            //            SulfurAvg = c.Single(),
            //            SulfurMax = c.Single(),
            //            MoistureAvg = c.Single(),
            //            MoistureMax = c.Single(),
            //            VolatileMatter = c.Single(),
            //            Caloricity = c.Single(),
            //            CaloricityMax = c.Single(),
            //            RockPerc = c.Single(),
            //            SmallFractPerc = c.Single(),
            //            xValue = c.Single(),
            //            yValue = c.Single(),
            //            InheritedFrom = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.WagonScales",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 255),
            //            NameEng = c.String(),
            //            LocationID = c.String(maxLength: 255),
            //            NameKZ = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Locations", t => t.LocationID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "dbo.WagonTransfers",
            //    c => new
            //        {
            //            ID = c.String(nullable: false, maxLength: 128),
            //            SublotName = c.String(maxLength: 255),
            //            WagonScaleID = c.Int(),
            //            WagonAnalysisID = c.Int(),
            //            Netto = c.Single(),
            //            OrderNumber = c.String(maxLength: 255),
            //            NettoByOrder = c.Single(),
            //            Direction = c.String(maxLength: 255),
            //            FromDestID = c.String(maxLength: 255),
            //            ToDest = c.String(maxLength: 255),
            //            LotName = c.String(nullable: false, maxLength: 255),
            //            Brutto = c.Single(nullable: false),
            //            Comment = c.String(maxLength: 255),
            //            OperatorName = c.String(maxLength: 255),
            //            Tare = c.Single(nullable: false),
            //            ItemID = c.Int(),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            TransferTimeStamp = c.DateTime(nullable: false),
            //            IsValid = c.Boolean(nullable: false),
            //            Status = c.Int(nullable: false),
            //            ApprovedBy = c.String(),
            //            InheritedFrom = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.WagonAnalysis", t => t.WagonAnalysisID)
            //    .ForeignKey("dbo.WagonScales", t => t.WagonScaleID)
            //    .ForeignKey("dbo.Locations", t => t.FromDestID)
            //    .ForeignKey("dbo.Items", t => t.ItemID)
            //    .Index(t => t.WagonScaleID)
            //    .Index(t => t.WagonAnalysisID)
            //    .Index(t => t.FromDestID)
            //    .Index(t => t.ItemID);
            
            //CreateTable(
            //    "dbo.WarehouseMeasures",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            WarehouseID = c.Int(),
            //            TotalMeasured = c.Double(),
            //            TotalCalculated = c.Double(),
            //            MeasureDate = c.DateTime(nullable: false),
            //            LasEditDateTime = c.DateTime(nullable: false),
            //            OperatorName = c.String(maxLength: 255),
            //            Comment = c.String(maxLength: 255),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Warehouses", t => t.WarehouseID)
            //    .Index(t => t.WarehouseID);
            
            //CreateTable(
            //    "dbo.Warehouses",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 255),
            //            NameEng = c.String(),
            //            NameKZ = c.String(),
            //            LocationID = c.String(maxLength: 255),
            //            TotalCapacity = c.Single(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Locations", t => t.LocationID)
            //    .Index(t => t.LocationID);
            
            //CreateTable(
            //    "dbo.WarehouseTransfers",
            //    c => new
            //        {
            //            ID = c.String(nullable: false, maxLength: 128),
            //            WarehouseID = c.Int(),
            //            TransferTimeStamp = c.DateTime(nullable: false),
            //            LotQuantity = c.Single(),
            //            TotalQuantity = c.Double(),
            //            Comment = c.String(maxLength: 255),
            //            IsManual = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Warehouses", t => t.WarehouseID)
            //    .Index(t => t.WarehouseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WarehouseTransfers", "WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.WarehouseMeasures", "WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.Warehouses", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.WagonTransfers", "ItemID", "dbo.Items");
            DropForeignKey("dbo.WagonTransfers", "FromDestID", "dbo.Locations");
            DropForeignKey("dbo.WagonTransfers", "WagonScaleID", "dbo.WagonScales");
            DropForeignKey("dbo.WagonTransfers", "WagonAnalysisID", "dbo.WagonAnalysis");
            DropForeignKey("dbo.WagonScales", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.VehiTransfers", "ItemID", "dbo.Items");
            DropForeignKey("dbo.VehiTransfers", "FromDestID", "dbo.Locations");
            DropForeignKey("dbo.VehiTransfers", "VehiScaleID", "dbo.VehiScales");
            DropForeignKey("dbo.VehiScales", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.SkipWeights", "SkipID", "dbo.Skips");
            DropForeignKey("dbo.SkipTransfers", "SkipID", "dbo.Skips");
            DropForeignKey("dbo.SkipTransfers", "SkipAnalysisID", "dbo.SkipAnalysis");
            DropForeignKey("dbo.Skips", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.RockUtilTransfers", "RockUtilID", "dbo.RockUtils");
            DropForeignKey("dbo.RockUtils", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.BeltTransfers", "ItemID", "dbo.Items");
            DropForeignKey("dbo.Items", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.BeltTransfers", "BeltScaleID", "dbo.BeltScales");
            DropForeignKey("dbo.BeltTransfers", "BeltAnalysisID", "dbo.BeltAnalysis");
            DropForeignKey("dbo.BoilerConsNorms", "ID", "dbo.Locations");
            DropForeignKey("dbo.BeltScales", "ToInnerDestID", "dbo.InnerDestinations");
            DropForeignKey("dbo.BeltScales", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.BeltScales", "FromInnerDestID", "dbo.InnerDestinations");
            DropForeignKey("dbo.InnerDestinations", "LocationID", "dbo.Locations");
            DropIndex("dbo.WarehouseTransfers", new[] { "WarehouseID" });
            DropIndex("dbo.Warehouses", new[] { "LocationID" });
            DropIndex("dbo.WarehouseMeasures", new[] { "WarehouseID" });
            DropIndex("dbo.WagonTransfers", new[] { "ItemID" });
            DropIndex("dbo.WagonTransfers", new[] { "FromDestID" });
            DropIndex("dbo.WagonTransfers", new[] { "WagonAnalysisID" });
            DropIndex("dbo.WagonTransfers", new[] { "WagonScaleID" });
            DropIndex("dbo.WagonScales", new[] { "LocationID" });
            DropIndex("dbo.VehiTransfers", new[] { "ItemID" });
            DropIndex("dbo.VehiTransfers", new[] { "FromDestID" });
            DropIndex("dbo.VehiTransfers", new[] { "VehiScaleID" });
            DropIndex("dbo.VehiScales", new[] { "LocationID" });
            DropIndex("dbo.SkipWeights", new[] { "SkipID" });
            DropIndex("dbo.SkipTransfers", new[] { "SkipAnalysisID" });
            DropIndex("dbo.SkipTransfers", new[] { "SkipID" });
            DropIndex("dbo.Skips", new[] { "LocationID" });
            DropIndex("dbo.RockUtilTransfers", new[] { "RockUtilID" });
            DropIndex("dbo.RockUtils", new[] { "LocationID" });
            DropIndex("dbo.Items", new[] { "LocationID" });
            DropIndex("dbo.BeltTransfers", new[] { "BeltAnalysisID" });
            DropIndex("dbo.BeltTransfers", new[] { "ItemID" });
            DropIndex("dbo.BeltTransfers", new[] { "BeltScaleID" });
            DropIndex("dbo.BoilerConsNorms", new[] { "ID" });
            DropIndex("dbo.InnerDestinations", new[] { "LocationID" });
            DropIndex("dbo.BeltScales", new[] { "ToInnerDestID" });
            DropIndex("dbo.BeltScales", new[] { "FromInnerDestID" });
            DropIndex("dbo.BeltScales", new[] { "LocationID" });
            DropTable("dbo.WarehouseTransfers");
            DropTable("dbo.Warehouses");
            DropTable("dbo.WarehouseMeasures");
            DropTable("dbo.WagonTransfers");
            DropTable("dbo.WagonScales");
            DropTable("dbo.WagonAnalysis");
            DropTable("dbo.VehiTransfers");
            DropTable("dbo.VehiScales");
            DropTable("dbo.UserRoles");
            DropTable("dbo.SkipWeights");
            DropTable("dbo.SkipTransfers");
            DropTable("dbo.Skips");
            DropTable("dbo.SkipAnalysis");
            DropTable("dbo.RockUtilTransfers");
            DropTable("dbo.RockUtils");
            DropTable("dbo.OraclePlanB");
            DropTable("dbo.OracleStaff");
            DropTable("dbo.OrcalePlanWithShop_ID");
            DropTable("dbo.LocalStaff");
            DropTable("dbo.LocalPlanWithLocationID");
            DropTable("dbo.LocalPlanBWithLocationID");
            DropTable("dbo.LocalPlanB");
            DropTable("dbo.LocalPlan");
            DropTable("dbo.Items");
            DropTable("dbo.BeltTransfers");
            DropTable("dbo.BoilerConsNorms");
            DropTable("dbo.Locations");
            DropTable("dbo.InnerDestinations");
            DropTable("dbo.BeltScales");
            DropTable("dbo.BeltAnalysis");
        }
    }
}
