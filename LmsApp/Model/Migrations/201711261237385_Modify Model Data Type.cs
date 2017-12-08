namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyModelDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contents", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contents", "Category", c => c.String(nullable: false));
        }
    }
}
