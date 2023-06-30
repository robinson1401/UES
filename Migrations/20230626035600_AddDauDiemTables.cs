using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UES.Migrations
{
    /// <inheritdoc />
    public partial class AddDauDiemTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DauDiem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThanhPhanDiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemHeBon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemHeBonBangChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemHeMuoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemHeMuoiBangChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemQuyDoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemToiThieuQuaMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_DauDiem", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DauDiem");
        }
    }
}
