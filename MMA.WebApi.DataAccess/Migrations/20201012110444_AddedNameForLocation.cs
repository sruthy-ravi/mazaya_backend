﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MMA.WebApi.DataAccess.Migrations
{
    public partial class AddedNameForLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "DefaultLocation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "DefaultLocation");
        }
    }
}
