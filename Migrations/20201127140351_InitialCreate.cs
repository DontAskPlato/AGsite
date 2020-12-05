﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AGsite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Answer1 = table.Column<string>(type: "TEXT", nullable: true),
                    Answer2 = table.Column<string>(type: "TEXT", nullable: true),
                    Answer3 = table.Column<string>(type: "TEXT", nullable: true),
                    Answer4 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyAnswers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyAnswers");
        }
    }
}
