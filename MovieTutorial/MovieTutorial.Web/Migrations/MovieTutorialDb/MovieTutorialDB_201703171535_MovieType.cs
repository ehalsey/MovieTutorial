using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.MovieTutorialDB
{
    [Migration(201703171535)]
    public class MovieTutorialDB_201703171535_MovieType : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                            .AddColumn("Kind").AsInt32().NotNullable()
                                .WithDefaultValue(1);
        }

        public override void Down()
        {
        }
    }
}