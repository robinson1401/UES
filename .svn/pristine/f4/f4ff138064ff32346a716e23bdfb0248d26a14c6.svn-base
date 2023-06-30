using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UES.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHdtCtdtNganhTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocPhan_GeneralStructure_GeneralStructureId",
                table: "HocPhan");

            migrationBuilder.DropTable(
                name: "HocPhanNganh");

            migrationBuilder.DropTable(
                name: "TrainingProgram");

            migrationBuilder.DropTable(
                name: "TrainingType");

            migrationBuilder.DropTable(
                name: "GeneralStructure");

            migrationBuilder.DropIndex(
                name: "IX_HocPhan_GeneralStructureId",
                table: "HocPhan");

            migrationBuilder.DropColumn(
                name: "NgayThanhLap",
                table: "Nganh");

            migrationBuilder.DropColumn(
                name: "GeneralStructureId",
                table: "HocPhan");

            migrationBuilder.RenameColumn(
                name: "TenVietTat",
                table: "Nganh",
                newName: "MaHDT");

            migrationBuilder.AddColumn<Guid>(
                name: "HeDaoTaoId",
                table: "Nganh",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ChuongTrinhDaoTaoId",
                table: "HocPhan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "MaCTDT",
                table: "HocPhan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ChuongTrinhDaoTao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNganh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NganhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaCTDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenCTDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiBang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuanDauRa = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_ChuongTrinhDaoTao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChuongTrinhDaoTao_Nganh_NganhId",
                        column: x => x.NganhId,
                        principalTable: "Nganh",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HeDaoTao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenHDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_HeDaoTao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nganh_HeDaoTaoId",
                table: "Nganh",
                column: "HeDaoTaoId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhan_ChuongTrinhDaoTaoId",
                table: "HocPhan",
                column: "ChuongTrinhDaoTaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTao_NganhId",
                table: "ChuongTrinhDaoTao",
                column: "NganhId");

            migrationBuilder.AddForeignKey(
                name: "FK_HocPhan_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                table: "HocPhan",
                column: "ChuongTrinhDaoTaoId",
                principalTable: "ChuongTrinhDaoTao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nganh_HeDaoTao_HeDaoTaoId",
                table: "Nganh",
                column: "HeDaoTaoId",
                principalTable: "HeDaoTao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocPhan_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                table: "HocPhan");

            migrationBuilder.DropForeignKey(
                name: "FK_Nganh_HeDaoTao_HeDaoTaoId",
                table: "Nganh");

            migrationBuilder.DropTable(
                name: "ChuongTrinhDaoTao");

            migrationBuilder.DropTable(
                name: "HeDaoTao");

            migrationBuilder.DropIndex(
                name: "IX_Nganh_HeDaoTaoId",
                table: "Nganh");

            migrationBuilder.DropIndex(
                name: "IX_HocPhan_ChuongTrinhDaoTaoId",
                table: "HocPhan");

            migrationBuilder.DropColumn(
                name: "HeDaoTaoId",
                table: "Nganh");

            migrationBuilder.DropColumn(
                name: "ChuongTrinhDaoTaoId",
                table: "HocPhan");

            migrationBuilder.DropColumn(
                name: "MaCTDT",
                table: "HocPhan");

            migrationBuilder.RenameColumn(
                name: "MaHDT",
                table: "Nganh",
                newName: "TenVietTat");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayThanhLap",
                table: "Nganh",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "GeneralStructureId",
                table: "HocPhan",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GeneralStructure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralStructure", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "TrainingType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeneralStructureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MajorId = table.Column<int>(type: "int", nullable: false),
                    MajorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objectives = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingDuration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgram_GeneralStructure_GeneralStructureId",
                        column: x => x.GeneralStructureId,
                        principalTable: "GeneralStructure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocPhan_GeneralStructureId",
                table: "HocPhan",
                column: "GeneralStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhanNganh_NganhsId",
                table: "HocPhanNganh",
                column: "NganhsId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgram_GeneralStructureId",
                table: "TrainingProgram",
                column: "GeneralStructureId");

            migrationBuilder.AddForeignKey(
                name: "FK_HocPhan_GeneralStructure_GeneralStructureId",
                table: "HocPhan",
                column: "GeneralStructureId",
                principalTable: "GeneralStructure",
                principalColumn: "Id");
        }
    }
}
