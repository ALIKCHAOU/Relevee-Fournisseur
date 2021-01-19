namespace Retenu_Fournisseur.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseDonees",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        NameDataBase = c.String(),
                        ServerName = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        autentificationWindows = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BaseDonees");
        }
    }
}
