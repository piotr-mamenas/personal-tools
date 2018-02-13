namespace wR.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingUnnecessaryIsDeletedProp : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GuessAttempts", "IsDeleted");
            DropColumn("dbo.Languages", "IsDeleted");
            DropColumn("dbo.TranslationRow", "IsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TranslationRow", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Languages", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.GuessAttempts", "IsDeleted", c => c.Boolean(nullable: false));
        }
    }
}
