using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UES.Migrations
{
    /// <inheritdoc />
    public partial class AlterHocPHanNganhTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocPhanNganh");

            migrationBuilder.AddColumn<Guid>(
                name: "HocPhanId",
                table: "Nganh",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nganh_HocPhanId",
                table: "Nganh",
                column: "HocPhanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nganh_HocPhan_HocPhanId",
                table: "Nganh",
                column: "HocPhanId",
                principalTable: "HocPhan",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nganh_HocPhan_HocPhanId",
                table: "Nganh");

            migrationBuilder.DropIndex(
                name: "IX_Nganh_HocPhanId",
                table: "Nganh");

            migrationBuilder.DropColumn(
                name: "HocPhanId",
                table: "Nganh");

            migrationBuilder.CreateTable(
                name: "HocPhanNganh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NganhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhanNganh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HocPhanNganh_HocPhan_HocPhanId",
                        column: x => x.HocPhanId,
                        principalTable: "HocPhan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HocPhanNganh_Nganh_NganhId",
                        column: x => x.NganhId,
                        principalTable: "Nganh",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocPhanNganh_HocPhanId",
                table: "HocPhanNganh",
                column: "HocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhanNganh_NganhId",
                table: "HocPhanNganh",
                column: "NganhId");
        }
    }
}
