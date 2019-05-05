namespace RainCheckUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false),
                        ProvinceId = c.Int(nullable: false),
                        Province_ProvinceId = c.Int(),
                        Province_ProvinceId1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceId1, cascadeDelete: true)
                .Index(t => t.Province_ProvinceId)
                .Index(t => t.Province_ProvinceId1);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceId = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Forecasts",
                c => new
                    {
                        ForecastId = c.Int(nullable: false, identity: true),
                        ForecastDate = c.DateTime(nullable: false),
                        MinTemp = c.Double(nullable: false),
                        MaxTemp = c.Double(nullable: false),
                        Precipitation = c.Double(nullable: false),
                        Humidity = c.Double(nullable: false),
                        WindSpeed = c.Double(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ForecastId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(nullable: false),
                        isAdmin = c.Boolean(nullable: false),
                        CityId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Forecasts", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "Province_ProvinceId1", "dbo.Provinces");
            DropForeignKey("dbo.Cities", "Province_ProvinceId", "dbo.Provinces");
            DropIndex("dbo.Users", new[] { "CityId" });
            DropIndex("dbo.Forecasts", new[] { "CityId" });
            DropIndex("dbo.Cities", new[] { "Province_ProvinceId1" });
            DropIndex("dbo.Cities", new[] { "Province_ProvinceId" });
            DropTable("dbo.Users");
            DropTable("dbo.Forecasts");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
