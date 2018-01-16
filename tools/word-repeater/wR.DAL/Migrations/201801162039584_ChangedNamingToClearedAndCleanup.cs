namespace wR.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNamingToClearedAndCleanup : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.GuessAttempts", name: "WasCorrectlyAnswered", newName: "IsCorrect");
            AddColumn("dbo.GuessAttempts", "SourceText", c => c.String(nullable: false));
            AddColumn("dbo.GuessAttempts", "Translation", c => c.String(nullable: false));
            AddColumn("dbo.GuessAttempts", "IsMarkedCorrect", c => c.Boolean(nullable: false));
            DropColumn("dbo.GuessAttempts", "GuessSource");
            DropColumn("dbo.GuessAttempts", "GuessDestination");
            DropColumn("dbo.GuessAttempts", "IsMeaningRetained");
            DropColumn("dbo.GuessAttempts", "IsMarkedAsCorrect");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GuessAttempts", "IsMarkedAsCorrect", c => c.Boolean(nullable: false));
            AddColumn("dbo.GuessAttempts", "IsMeaningRetained", c => c.Boolean(nullable: false));
            AddColumn("dbo.GuessAttempts", "GuessDestination", c => c.String(nullable: false));
            AddColumn("dbo.GuessAttempts", "GuessSource", c => c.String(nullable: false));
            DropColumn("dbo.GuessAttempts", "IsMarkedCorrect");
            DropColumn("dbo.GuessAttempts", "Translation");
            DropColumn("dbo.GuessAttempts", "SourceText");
            RenameColumn(table: "dbo.GuessAttempts", name: "IsCorrect", newName: "WasCorrectlyAnswered");
        }
    }
}
