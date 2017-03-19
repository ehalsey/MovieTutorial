using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.MovieTutorialDB
{
    [Migration(201703181708)]
    public class MovieTutorialDB_201703181708_Genres : Migration
    {
        public override void Up()
        {
            Create.Table("Genre").InSchema("mov")
                 .WithColumn("GenreId").AsInt32().NotNullable()
                     .PrimaryKey().Identity()
                 .WithColumn("Name").AsString(100).NotNullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("GenreId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId");
        }

        public override void Down()
        {
        }
    }
}