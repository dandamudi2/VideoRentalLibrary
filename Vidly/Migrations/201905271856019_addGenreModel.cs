namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenreModel : DbMigration
    {
        public override void Up()
        {
            Sql("insert dbo.Genres(id,Name) values(1,'Action')");
            Sql("insert dbo.Genres(id,Name) values(2,'Family')");
            Sql("insert dbo.Genres(id,Name) values(3,'Suspense')");


            Sql("insert into dbo.Movies(Name,ReleaseDate,DateAdded,GenreId) values('Gorilla',getdate(),getdate(),1)");
            Sql("insert into dbo.Movies(Name,ReleaseDate,DateAdded,GenreId) " +
                "values('Sita',getdate(),getdate(),2)");

        }
        
        public override void Down()
        {
        }
    }
}
