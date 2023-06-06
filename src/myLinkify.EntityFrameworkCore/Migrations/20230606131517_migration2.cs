using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myLinkify.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SarsNumbers");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "Grant_Id",
                table: "Grants");

            migrationBuilder.DropColumn(
                name: "ExpiraryDate",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "SarsNumberId",
                table: "SarsNumbers",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "SpouseId",
                table: "GrantsUsers",
                newName: "SpouseIdNumber");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "Cards",
                newName: "ExpiraryDateYear");

            migrationBuilder.RenameColumn(
                name: "BookingTooken",
                table: "Bookings",
                newName: "BookingToken");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Transactiondate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "SarsNumbers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "BankLetterId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BankStatementId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IncomeDocumentId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MarriageCertificateId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PoliceAffidavitId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SassaAffidavitId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SchoolLetterId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SocialWorkerReportId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SpouseAffidavitId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UifCardId",
                table: "GrantsUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpiraryDateMonth",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Cards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Bookings",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "Bookings",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AlterColumn<int>(
                name: "Province",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseNumber",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StoredFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoredFiles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PersonId",
                table: "Transactions",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SarsNumbers_PersonId",
                table: "SarsNumbers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_BankLetterId",
                table: "GrantsUsers",
                column: "BankLetterId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_BankStatementId",
                table: "GrantsUsers",
                column: "BankStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_IncomeDocumentId",
                table: "GrantsUsers",
                column: "IncomeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_MarriageCertificateId",
                table: "GrantsUsers",
                column: "MarriageCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_PersonId",
                table: "GrantsUsers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_PoliceAffidavitId",
                table: "GrantsUsers",
                column: "PoliceAffidavitId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_SassaAffidavitId",
                table: "GrantsUsers",
                column: "SassaAffidavitId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_SchoolLetterId",
                table: "GrantsUsers",
                column: "SchoolLetterId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_SocialWorkerReportId",
                table: "GrantsUsers",
                column: "SocialWorkerReportId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_SpouseAffidavitId",
                table: "GrantsUsers",
                column: "SpouseAffidavitId");

            migrationBuilder.CreateIndex(
                name: "IX_GrantsUsers_UifCardId",
                table: "GrantsUsers",
                column: "UifCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PersonId",
                table: "Cards",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PersonId",
                table: "Bookings",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Persons_PersonId",
                table: "Bookings",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Persons_PersonId",
                table: "Cards",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_Persons_PersonId",
                table: "GrantsUsers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_BankLetterId",
                table: "GrantsUsers",
                column: "BankLetterId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_BankStatementId",
                table: "GrantsUsers",
                column: "BankStatementId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_IncomeDocumentId",
                table: "GrantsUsers",
                column: "IncomeDocumentId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_MarriageCertificateId",
                table: "GrantsUsers",
                column: "MarriageCertificateId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_PoliceAffidavitId",
                table: "GrantsUsers",
                column: "PoliceAffidavitId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_SassaAffidavitId",
                table: "GrantsUsers",
                column: "SassaAffidavitId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_SchoolLetterId",
                table: "GrantsUsers",
                column: "SchoolLetterId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_SocialWorkerReportId",
                table: "GrantsUsers",
                column: "SocialWorkerReportId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_SpouseAffidavitId",
                table: "GrantsUsers",
                column: "SpouseAffidavitId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GrantsUsers_StoredFiles_UifCardId",
                table: "GrantsUsers",
                column: "UifCardId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SarsNumbers_Persons_PersonId",
                table: "SarsNumbers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Persons_PersonId",
                table: "Transactions",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Persons_PersonId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Persons_PersonId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_Persons_PersonId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_BankLetterId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_BankStatementId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_IncomeDocumentId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_MarriageCertificateId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_PoliceAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_SassaAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_SchoolLetterId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_SocialWorkerReportId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_SpouseAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GrantsUsers_StoredFiles_UifCardId",
                table: "GrantsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_SarsNumbers_Persons_PersonId",
                table: "SarsNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Persons_PersonId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "StoredFiles");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PersonId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_SarsNumbers_PersonId",
                table: "SarsNumbers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_BankLetterId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_BankStatementId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_IncomeDocumentId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_MarriageCertificateId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_PersonId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_PoliceAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_SassaAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_SchoolLetterId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_SocialWorkerReportId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_SpouseAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_GrantsUsers_UifCardId",
                table: "GrantsUsers");

            migrationBuilder.DropIndex(
                name: "IX_Cards_PersonId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_PersonId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Transactiondate",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "SarsNumbers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "BankLetterId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "BankStatementId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "IncomeDocumentId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "MarriageCertificateId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "PoliceAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "SassaAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "SchoolLetterId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "SocialWorkerReportId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "SpouseAffidavitId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "UifCardId",
                table: "GrantsUsers");

            migrationBuilder.DropColumn(
                name: "ExpiraryDateMonth",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "SarsNumbers",
                newName: "SarsNumberId");

            migrationBuilder.RenameColumn(
                name: "SpouseIdNumber",
                table: "GrantsUsers",
                newName: "SpouseId");

            migrationBuilder.RenameColumn(
                name: "ExpiraryDateYear",
                table: "Cards",
                newName: "CardId");

            migrationBuilder.RenameColumn(
                name: "BookingToken",
                table: "Bookings",
                newName: "BookingTooken");

            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "SarsNumbers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationId",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "GrantsUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grant_Id",
                table: "Grants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpiraryDate",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "BookingId",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
