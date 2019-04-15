namespace OnHelp.Api.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablesAndDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Receita",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 250),
                        Ingredients = c.String(nullable: false, maxLength: 800),
                        MethodOfPreparation = c.String(nullable: false, maxLength: 1000),
                        Image = c.Binary(),
                        Tags = c.String(),
                        CategoryId = c.Int(nullable: false),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receita", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Receita", new[] { "Categoria_Id" });
            DropTable("dbo.Receita");
            DropTable("dbo.Categoria");
        }
    }
}
