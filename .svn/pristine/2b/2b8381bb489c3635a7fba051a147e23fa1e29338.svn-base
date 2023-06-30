using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UES.Migrations
{
    /// <inheritdoc />
    public partial class AddGeneralStructureTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GeneralStructureId",
                table: "TrainingProgram",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_GeneralStructure", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgram_GeneralStructureId",
                table: "TrainingProgram",
                column: "GeneralStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhan_GeneralStructureId",
                table: "HocPhan",
                column: "GeneralStructureId");

            migrationBuilder.AddForeignKey(
                name: "FK_HocPhan_GeneralStructure_GeneralStructureId",
                table: "HocPhan",
                column: "GeneralStructureId",
                principalTable: "GeneralStructure",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingProgram_GeneralStructure_GeneralStructureId",
                table: "TrainingProgram",
                column: "GeneralStructureId",
                principalTable: "GeneralStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocPhan_GeneralStructure_GeneralStructureId",
                table: "HocPhan");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProgram_GeneralStructure_GeneralStructureId",
                table: "TrainingProgram");

            migrationBuilder.DropTable(
                name: "GeneralStructure");

            migrationBuilder.DropIndex(
                name: "IX_TrainingProgram_GeneralStructureId",
                table: "TrainingProgram");

            migrationBuilder.DropIndex(
                name: "IX_HocPhan_GeneralStructureId",
                table: "HocPhan");

            migrationBuilder.DropColumn(
                name: "GeneralStructureId",
                table: "TrainingProgram");

            migrationBuilder.DropColumn(
                name: "GeneralStructureId",
                table: "HocPhan");
        }
    }
}
