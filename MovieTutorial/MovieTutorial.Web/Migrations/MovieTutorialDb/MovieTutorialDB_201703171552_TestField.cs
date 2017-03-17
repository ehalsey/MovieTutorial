using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.MovieTutorialDB
{
    [Migration(201703171552)]
    public class MovieTutorialDB_201703171552_TestField : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                            .AddColumn("TestField").AsString(100).Nullable();
        }

        public override void Down()
        {
        }
    }
}