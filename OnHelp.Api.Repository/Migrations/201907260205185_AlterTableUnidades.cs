namespace OnHelp.Api.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableUnidades : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Unidade", "Endereco", c => c.String(nullable: false));
            AddColumn("dbo.Unidade", "Cep", c => c.String(nullable: false));
            AddColumn("dbo.Unidade", "Estado", c => c.String(nullable: false));
            AddColumn("dbo.Unidade", "Cidade", c => c.String(nullable: false));
            AlterColumn("dbo.Unidade", "LotacaoTotal", c => c.Int(nullable: false));
            AlterColumn("dbo.Unidade", "LotacaoAtual", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Unidade", "LotacaoAtual", c => c.String(nullable: false));
            AlterColumn("dbo.Unidade", "LotacaoTotal", c => c.String(nullable: false));
            DropColumn("dbo.Unidade", "Cidade");
            DropColumn("dbo.Unidade", "Estado");
            DropColumn("dbo.Unidade", "Cep");
            DropColumn("dbo.Unidade", "Endereco");
        }
    }
}
