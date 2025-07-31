using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstTaskR.Migrations
{
    /// <inheritdoc />
    public partial class reload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "object_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 42, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_object_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "objects",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 42, nullable: false),
                    type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objects", x => x.id);
                    table.ForeignKey(
                        name: "FK_objects_object_types_type",
                        column: x => x.type,
                        principalTable: "object_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "well_day_histories",
                columns: table => new
                {
                    well = table.Column<int>(type: "INTEGER", nullable: false),
                    date_fact = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    debit = table.Column<short>(type: "INTEGER", nullable: false),
                    ee_consume = table.Column<float>(type: "REAL", precision: 5, scale: 2, nullable: false),
                    expenses = table.Column<float>(type: "REAL", precision: 4, scale: 3, nullable: false),
                    pump_operating = table.Column<short>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_well_day_histories", x => new { x.well, x.date_fact });
                    table.ForeignKey(
                        name: "FK_well_day_histories_objects_well",
                        column: x => x.well,
                        principalTable: "objects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "well_day_plans",
                columns: table => new
                {
                    well = table.Column<int>(type: "INTEGER", nullable: false),
                    date_plan = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    debit = table.Column<short>(type: "INTEGER", nullable: false),
                    ee_consume = table.Column<float>(type: "REAL", precision: 5, scale: 2, nullable: false),
                    expenses = table.Column<float>(type: "REAL", precision: 4, scale: 3, nullable: false),
                    pump_operating = table.Column<short>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_well_day_plans", x => new { x.well, x.date_plan });
                    table.ForeignKey(
                        name: "FK_well_day_plans_objects_well",
                        column: x => x.well,
                        principalTable: "objects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wells",
                columns: table => new
                {
                    well = table.Column<int>(type: "INTEGER", nullable: false),
                    ngdu = table.Column<int>(type: "INTEGER", nullable: false),
                    cdng = table.Column<int>(type: "INTEGER", nullable: false),
                    kust = table.Column<int>(type: "INTEGER", nullable: false),
                    mest = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wells", x => x.well);
                    table.ForeignKey(
                        name: "FK_wells_objects_cdng",
                        column: x => x.cdng,
                        principalTable: "objects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wells_objects_kust",
                        column: x => x.kust,
                        principalTable: "objects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wells_objects_mest",
                        column: x => x.mest,
                        principalTable: "objects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wells_objects_ngdu",
                        column: x => x.ngdu,
                        principalTable: "objects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wells_objects_well",
                        column: x => x.well,
                        principalTable: "objects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_objects_type",
                table: "objects",
                column: "type");

            migrationBuilder.CreateIndex(
                name: "IX_wells_cdng",
                table: "wells",
                column: "cdng");

            migrationBuilder.CreateIndex(
                name: "IX_wells_kust",
                table: "wells",
                column: "kust");

            migrationBuilder.CreateIndex(
                name: "IX_wells_mest",
                table: "wells",
                column: "mest");

            migrationBuilder.CreateIndex(
                name: "IX_wells_ngdu",
                table: "wells",
                column: "ngdu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "well_day_histories");

            migrationBuilder.DropTable(
                name: "well_day_plans");

            migrationBuilder.DropTable(
                name: "wells");

            migrationBuilder.DropTable(
                name: "objects");

            migrationBuilder.DropTable(
                name: "object_types");
        }
    }
}
