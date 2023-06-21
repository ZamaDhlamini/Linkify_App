using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myLinkify.Migrations
{
    public partial class _202306201551migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Persons_PersonId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Cards",
                newName: "GrantUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_PersonId",
                table: "Cards",
                newName: "IX_Cards_GrantUserId");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Persons_GrantUserId",
                table: "Cards",
                column: "GrantUserId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Persons_GrantUserId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AddressId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "GrantUserId",
                table: "Cards",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_GrantUserId",
                table: "Cards",
                newName: "IX_Cards_PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Persons_PersonId",
                table: "Cards",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
