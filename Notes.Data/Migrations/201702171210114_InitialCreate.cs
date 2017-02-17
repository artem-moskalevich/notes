namespace Notes.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        head = c.String(maxLength: 250, storeType: "nvarchar"),
                        body = c.String(maxLength: 1000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notes");
        }
    }
}
