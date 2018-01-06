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
                        Id = c.Guid(nullable: false),
                        SourceContent = c.String(),
                        SourceLanguageId = c.Guid(nullable: false),
                        DestinationContent = c.String(),
                        DestinationLanguageId = c.Guid(nullable: false),
                        MeaningRetained = c.Boolean(nullable: false),
                        MarkedAsCorrect = c.Boolean(nullable: false),
                        Correct = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Languages", t => t.DestinationLanguageId, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.SourceLanguageId, cascadeDelete: true)
                .Index(t => t.SourceLanguageId)
                .Index(t => t.DestinationLanguageId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TranslationRows",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        English = c.String(),
                        German = c.String(),
                        French = c.String(),
                        Polish = c.String(),
                        Spanish = c.String(),
                        Italian = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GuessAttempts", "SourceLanguageId", "dbo.Languages");
            DropForeignKey("dbo.GuessAttempts", "DestinationLanguageId", "dbo.Languages");
            DropIndex("dbo.GuessAttempts", new[] { "DestinationLanguageId" });
            DropIndex("dbo.GuessAttempts", new[] { "SourceLanguageId" });
            DropTable("dbo.TranslationRows");
            DropTable("dbo.Languages");
            DropTable("dbo.GuessAttempts");
        }
    }
}
