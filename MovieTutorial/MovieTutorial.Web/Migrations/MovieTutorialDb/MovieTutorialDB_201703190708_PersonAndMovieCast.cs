﻿using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.MovieTutorialDB
{
    [Migration(201703190708)]
    public class MovieTutorialDB_201703190708_PersonAndMovieCast : Migration
    {
        public override void Up()
        {
            Create.Table("Person").InSchema("mov")
                .WithColumn("PersonId").AsInt32().Identity()
                    .PrimaryKey().NotNullable()
                .WithColumn("Firstname").AsString(50).NotNullable()
                .WithColumn("Lastname").AsString(50).NotNullable()
                .WithColumn("BirthDate").AsDateTime().Nullable()
                .WithColumn("BirthPlace").AsString(100).Nullable()
                .WithColumn("Gender").AsInt32().Nullable()
                .WithColumn("Height").AsInt32().Nullable();

            Create.Table("MovieCast").InSchema("mov")
                .WithColumn("MovieCastId").AsInt32().Identity()
                    .PrimaryKey().NotNullable()
                .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_MovieId", "mov", "Movie", "MovieId")
                .WithColumn("PersonId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_PersonId", "mov", "Person", "PersonId")
                .WithColumn("Character").AsString(50).Nullable();
        }

        public override void Down()
        {
        }
    }
}