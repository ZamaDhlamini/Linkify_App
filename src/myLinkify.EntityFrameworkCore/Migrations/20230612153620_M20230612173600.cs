using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myLinkify.Migrations
{
    public partial class M20230612173600 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrantsUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "BankLetterId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BankStatementId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "IncomeDocumentId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MarriageCertificateId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PoliceAffidavitId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SassaAffidavitId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SchoolLetterId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SocialWorkerReportId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SpouseAffidavitId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpouseIdNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UifCardId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BankLetterId",
                table: "Persons",
                column: "BankLetterId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BankStatementId",
                table: "Persons",
                column: "BankStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_IncomeDocumentId",
                table: "Persons",
                column: "IncomeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MarriageCertificateId",
                table: "Persons",
                column: "MarriageCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PoliceAffidavitId",
                table: "Persons",
                column: "PoliceAffidavitId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SassaAffidavitId",
                table: "Persons",
                column: "SassaAffidavitId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SchoolLetterId",
                table: "Persons",
                column: "SchoolLetterId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SocialWorkerReportId",
                table: "Persons",
                column: "SocialWorkerReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SpouseAffidavitId",
                table: "Persons",
                column: "SpouseAffidavitId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_UifCardId",
                table: "Persons",
                column: "UifCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_BankLetterId",
                table: "Persons",
                column: "BankLetterId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_BankStatementId",
                table: "Persons",
                column: "BankStatementId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_IncomeDocumentId",
                table: "Persons",
                column: "IncomeDocumentId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_MarriageCertificateId",
                table: "Persons",
                column: "MarriageCertificateId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_PoliceAffidavitId",
                table: "Persons",
                column: "PoliceAffidavitId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_SassaAffidavitId",
                table: "Persons",
                column: "SassaAffidavitId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_SchoolLetterId",
                table: "Persons",
                column: "SchoolLetterId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_SocialWorkerReportId",
                table: "Persons",
                column: "SocialWorkerReportId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_SpouseAffidavitId",
                table: "Persons",
                column: "SpouseAffidavitId",
                principalTable: "StoredFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_UifCardId",
                table: "Persons",
                column: "UifCardId",
                principalTable: "StoredFiles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_BankLetterId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_BankStatementId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_IncomeDocumentId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_MarriageCertificateId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_PoliceAffidavitId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_SassaAffidavitId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_SchoolLetterId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_SocialWorkerReportId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_SpouseAffidavitId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_UifCardId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_BankLetterId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_BankStatementId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_IncomeDocumentId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MarriageCertificateId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PoliceAffidavitId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SassaAffidavitId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SchoolLetterId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SocialWorkerReportId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SpouseAffidavitId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_UifCardId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "BankLetterId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "BankStatementId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "IncomeDocumentId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MarriageCertificateId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PoliceAffidavitId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SassaAffidavitId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SchoolLetterId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SocialWorkerReportId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SpouseAffidavitId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SpouseIdNumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "UifCardId",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "GrantsUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankLetterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BankStatementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IncomeDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MarriageCertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PoliceAffidavitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SassaAffidavitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SchoolLetterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SocialWorkerReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpouseAffidavitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UifCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    SpouseIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantsUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrantsUsers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_BankLetterId",
                        column: x => x.BankLetterId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_BankStatementId",
                        column: x => x.BankStatementId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_IncomeDocumentId",
                        column: x => x.IncomeDocumentId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_MarriageCertificateId",
                        column: x => x.MarriageCertificateId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_PoliceAffidavitId",
                        column: x => x.PoliceAffidavitId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_SassaAffidavitId",
                        column: x => x.SassaAffidavitId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_SchoolLetterId",
                        column: x => x.SchoolLetterId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_SocialWorkerReportId",
                        column: x => x.SocialWorkerReportId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_SpouseAffidavitId",
                        column: x => x.SpouseAffidavitId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GrantsUsers_StoredFiles_UifCardId",
                        column: x => x.UifCardId,
                        principalTable: "StoredFiles",
                        principalColumn: "Id");
                });

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
        }
    }
}
