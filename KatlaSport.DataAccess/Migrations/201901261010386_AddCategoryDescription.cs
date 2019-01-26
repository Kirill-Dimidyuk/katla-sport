namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddCategoryDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.catalogue_products", "product_description", c => c.String(maxLength: 300));
            AddColumn("dbo.catalogue_products", "product_manufacturer_code", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.catalogue_products", "product_price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.product_categories", "category_description", c => c.String(maxLength: 300));
        }

        public override void Down()
        {
            DropColumn("dbo.product_categories", "category_description");
            DropColumn("dbo.catalogue_products", "product_price");
            DropColumn("dbo.catalogue_products", "product_manufacturer_code");
            DropColumn("dbo.catalogue_products", "product_description");
        }
    }
}
