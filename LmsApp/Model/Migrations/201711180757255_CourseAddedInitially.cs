namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseAddedInitially : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        Tags = c.String(nullable: false, maxLength: 100),
                        TeacherId = c.String(maxLength: 128),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.Title)
                .Index(t => t.Price)
                .Index(t => t.Tags)
                .Index(t => t.TeacherId)
                .Index(t => t.Created)
                .Index(t => t.CreatedBy)
                .Index(t => t.Modified)
                .Index(t => t.ModifiedBy);
            
            AddColumn("dbo.Teachers", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Teachers", "Contact", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Teachers", "Address", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Teachers", "Designation", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Teachers", "Details", c => c.String(maxLength: 500));
            AddColumn("dbo.Teachers", "Image", c => c.String(maxLength: 500));
            CreateIndex("dbo.Teachers", "Email");
            CreateIndex("dbo.Teachers", "Contact");
            CreateIndex("dbo.Teachers", "Designation");
            CreateIndex("dbo.Teachers", "Image");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Teachers", new[] { "Image" });
            DropIndex("dbo.Teachers", new[] { "Designation" });
            DropIndex("dbo.Teachers", new[] { "Contact" });
            DropIndex("dbo.Teachers", new[] { "Email" });
            DropIndex("dbo.Courses", new[] { "ModifiedBy" });
            DropIndex("dbo.Courses", new[] { "Modified" });
            DropIndex("dbo.Courses", new[] { "CreatedBy" });
            DropIndex("dbo.Courses", new[] { "Created" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.Courses", new[] { "Tags" });
            DropIndex("dbo.Courses", new[] { "Price" });
            DropIndex("dbo.Courses", new[] { "Title" });
            DropColumn("dbo.Teachers", "Image");
            DropColumn("dbo.Teachers", "Details");
            DropColumn("dbo.Teachers", "Designation");
            DropColumn("dbo.Teachers", "Address");
            DropColumn("dbo.Teachers", "Contact");
            DropColumn("dbo.Teachers", "Email");
            DropTable("dbo.Courses");
        }
    }
}
