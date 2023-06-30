using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UES.Migrations
{
    /// <inheritdoc />
    public partial class MigrationDauDiemHocPhanTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nganh_HocPhan_HocPhanId",
                table: "Nganh");

            migrationBuilder.DropTable(
                name: "khoa");

            migrationBuilder.DropIndex(
                name: "IX_Nganh_HocPhanId",
                table: "Nganh");

            migrationBuilder.DropColumn(
                name: "HocPhanId",
                table: "Nganh");

            migrationBuilder.DropColumn(
                name: "MaKhoa",
                table: "Nganh");

            migrationBuilder.RenameColumn(
                name: "mota",
                table: "Nganh",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "Tenviettat",
                table: "Nganh",
                newName: "TenVietTat");

            migrationBuilder.RenameColumn(
                name: "Tennganh",
                table: "Nganh",
                newName: "TenNganh");

            migrationBuilder.RenameColumn(
                name: "Ngaythanhlap",
                table: "Nganh",
                newName: "NgayThanhLap");

            migrationBuilder.AlterColumn<string>(
                name: "TenNganh",
                table: "Nganh",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MaNganh",
                table: "Nganh",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SoTinChi",
                table: "HocPhan",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "HocKy",
                table: "HocPhan",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "HocPhanNganh",
                columns: table => new
                {
                    HocPhansId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NganhsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhanNganh", x => new { x.HocPhansId, x.NganhsId });
                    table.ForeignKey(
                        name: "FK_HocPhanNganh_HocPhan_HocPhansId",
                        column: x => x.HocPhansId,
                        principalTable: "HocPhan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocPhanNganh_Nganh_NganhsId",
                        column: x => x.NganhsId,
                        principalTable: "Nganh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocPhanNganh_NganhsId",
                table: "HocPhanNganh",
                column: "NganhsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocPhanNganh");

            migrationBuilder.RenameColumn(
                name: "TenVietTat",
                table: "Nganh",
                newName: "Tenviettat");

            migrationBuilder.RenameColumn(
                name: "TenNganh",
                table: "Nganh",
                newName: "Tennganh");

            migrationBuilder.RenameColumn(
                name: "NgayThanhLap",
                table: "Nganh",
                newName: "Ngaythanhlap");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "Nganh",
                newName: "mota");

            migrationBuilder.AlterColumn<string>(
                name: "Tennganh",
                table: "Nganh",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MaNganh",
                table: "Nganh",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "HocPhanId",
                table: "Nganh",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaKhoa",
                table: "Nganh",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "SoTinChi",
                table: "HocPhan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "HocKy",
                table: "HocPhan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "khoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaKhoa = table.Column<int>(type: "int", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tenkhoa = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Tenviettat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khoa", x => x.Id);
                });

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
    }
}
