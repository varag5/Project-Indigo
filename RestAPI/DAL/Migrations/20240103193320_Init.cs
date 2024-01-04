using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Itineraries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itineraries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stops",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Walks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Walks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Recordings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    RecordingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItineraryID = table.Column<int>(type: "int", nullable: false),
                    RouteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recordings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Recordings_Itineraries_ItineraryID",
                        column: x => x.ItineraryID,
                        principalTable: "Itineraries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recordings_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BoundedWalks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartID = table.Column<int>(type: "int", nullable: true),
                    EndID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoundedWalks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BoundedWalks_Stops_EndID",
                        column: x => x.EndID,
                        principalTable: "Stops",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BoundedWalks_Stops_StartID",
                        column: x => x.StartID,
                        principalTable: "Stops",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RouteJourneys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItineraryID = table.Column<int>(type: "int", nullable: true),
                    StartID = table.Column<int>(type: "int", nullable: true),
                    EndID = table.Column<int>(type: "int", nullable: true),
                    RouteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteJourneys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RouteJourneys_Itineraries_ItineraryID",
                        column: x => x.ItineraryID,
                        principalTable: "Itineraries",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RouteJourneys_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RouteJourneys_Stops_EndID",
                        column: x => x.EndID,
                        principalTable: "Stops",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RouteJourneys_Stops_StartID",
                        column: x => x.StartID,
                        principalTable: "Stops",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RouteStops",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    RouteID = table.Column<int>(type: "int", nullable: false),
                    StopID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteStops", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RouteStops_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteStops_Stops_StopID",
                        column: x => x.StopID,
                        principalTable: "Stops",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoundedWalks_EndID",
                table: "BoundedWalks",
                column: "EndID");

            migrationBuilder.CreateIndex(
                name: "IX_BoundedWalks_StartID",
                table: "BoundedWalks",
                column: "StartID");

            migrationBuilder.CreateIndex(
                name: "IX_Recordings_ItineraryID",
                table: "Recordings",
                column: "ItineraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Recordings_RouteID",
                table: "Recordings",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteJourneys_EndID",
                table: "RouteJourneys",
                column: "EndID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteJourneys_ItineraryID",
                table: "RouteJourneys",
                column: "ItineraryID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteJourneys_RouteID",
                table: "RouteJourneys",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteJourneys_StartID",
                table: "RouteJourneys",
                column: "StartID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteStops_RouteID",
                table: "RouteStops",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteStops_StopID",
                table: "RouteStops",
                column: "StopID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoundedWalks");

            migrationBuilder.DropTable(
                name: "Recordings");

            migrationBuilder.DropTable(
                name: "RouteJourneys");

            migrationBuilder.DropTable(
                name: "RouteStops");

            migrationBuilder.DropTable(
                name: "Walks");

            migrationBuilder.DropTable(
                name: "Itineraries");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Stops");
        }
    }
}
