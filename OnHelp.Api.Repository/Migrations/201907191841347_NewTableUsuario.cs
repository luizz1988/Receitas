namespace OnHelp.Api.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Senha = c.String(nullable: false, maxLength: 50),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "PessoaId", "dbo.Pessoa");
            DropIndex("dbo.Usuario", new[] { "PessoaId" });
            DropTable("dbo.Usuario");
        }
    }
}
