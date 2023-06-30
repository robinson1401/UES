using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UES.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHocPhanDauDiemNganhTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HocPhanId",
                table: "DauDiem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HocPhanNganh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HocPhan_NganhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NganhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhanNganh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HocPhanNganh_HocPhanNganh_HocPhan_NganhId",
                        column: x => x.HocPhan_NganhId,
                        principalTable: "HocPhanNganh",
                        principalColumn: "Id");
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
                name: "IX_DauDiem_HocPhanId",
                table: "DauDiem",
                column: "HocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhanNganh_HocPhan_NganhId",
                table: "HocPhanNganh",
                column: "HocPhan_NganhId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhanNganh_HocPhanId",
                table: "HocPhanNganh",
                column: "HocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhanNganh_NganhId",
                table: "HocPhanNganh",
                column: "NganhId");

            migrationBuilder.AddForeignKey(
                name: "FK_DauDiem_HocPhan_HocPhanId",
                table: "DauDiem",
                column: "HocPhanId",
                principalTable: "HocPhan",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DauDiem_HocPhan_HocPhanId",
                table: "DauDiem");

            migrationBuilder.DropTable(
                name: "HocPhanNganh");

            migrationBuilder.DropTable(
                name: "TodoItem");

            migrationBuilder.DropIndex(
                name: "IX_DauDiem_HocPhanId",
                table: "DauDiem");

            migrationBuilder.DropColumn(
                name: "HocPhanId",
                table: "DauDiem");
        }
    }
}
