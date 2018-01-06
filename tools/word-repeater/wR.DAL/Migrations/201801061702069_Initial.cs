namespace wR.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GuessAttempts",
                c => new
                    {
                        GuessAttemptId = c.Guid(nullable: false, identity: true),
                        GuessSource = c.String(nullable: false),
                        SourceLanguageId = c.Guid(nullable: false),
                        GuessDestination = c.String(nullable: false),
                        DestinationLanguageId = c.Guid(nullable: false),
                        TranslationRowId = c.Guid(nullable: false),
                        GuessedTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsMeaningRetained = c.Boolean(nullable: false),
                        IsMarkedAsCorrect = c.Boolean(nullable: false),
                        WasCorrectlyAnswered = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GuessAttemptId)
                .ForeignKey("dbo.Languages", t => t.DestinationLanguageId)
                .ForeignKey("dbo.Languages", t => t.SourceLanguageId)
                .ForeignKey("dbo.TranslationRow", t => t.TranslationRowId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Guid(nullable: false, identity: true),
                        LanguageName = c.String(),
                        LanguageCode = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            CreateTable(
                "dbo.TranslationRow",
                c => new
                    {
                        TranslationRowId = c.Guid(nullable: false, identity: true),
                        EnglishTranslation = c.String(),
                        GermanTranslation = c.String(),
                        FrenchTranslation = c.String(),
                        PolishTranslation = c.String(),
                        SpanishTranslation = c.String(),
                        ItalianTranslation = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TranslationRowId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GuessAttempts", "TranslationRowId", "dbo.TranslationRow");
            DropForeignKey("dbo.GuessAttempts", "SourceLanguageId", "dbo.Languages");
            DropForeignKey("dbo.GuessAttempts", "DestinationLanguageId", "dbo.Languages");
            DropTable("dbo.TranslationRow");
            DropTable("dbo.Languages");
            DropTable("dbo.GuessAttempts");
        }
    }
}
