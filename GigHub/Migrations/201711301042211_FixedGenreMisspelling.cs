namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class FixedGenreMisspelling : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_Id" });
            RenameColumn(table: "dbo.Gigs", name: "Genre_Id", newName: "GenreId");
            AlterColumn("dbo.Gigs", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Gigs", "GenreId");
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Gigs", "GenreId");
        }

        public override void Down()
        {
            AddColumn("dbo.Gigs", "GendreId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "GenreId" });
            AlterColumn("dbo.Gigs", "GenreId", c => c.Byte());
            RenameColumn(table: "dbo.Gigs", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Gigs", "Genre_Id");
            AddForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
