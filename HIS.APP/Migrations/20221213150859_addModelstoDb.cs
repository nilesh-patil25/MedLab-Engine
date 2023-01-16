using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.APP.Migrations
{
    /// <inheritdoc />
    public partial class addModelstoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auditblobs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageTextOrRawData = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditblobs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Audittables",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageSendingSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivedDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageTextLinktoUnstructuredStorage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsWebHookSend = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audittables", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ObservationLabResults",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservationText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservationValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservationReferenceRange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservationEffectiveDatetime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservationPerformer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObservationLabResults", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Patientdemographics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITSSID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfResidence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Ethnicity = table.Column<int>(type: "int", nullable: true),
                    Literacy = table.Column<int>(type: "int", nullable: true),
                    Education = table.Column<int>(type: "int", nullable: true),
                    YearsInHighestLevel = table.Column<int>(type: "int", nullable: true),
                    CivilStatus = table.Column<int>(type: "int", nullable: true),
                    LivesAlone = table.Column<int>(type: "int", nullable: true),
                    RecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patientdemographics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRequestIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceRequestIdentifierType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceRequestAuthoredonDatefield = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequesterPractitionerIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequesterPractitionerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequesterPractitionerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequests", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auditblobs");

            migrationBuilder.DropTable(
                name: "Audittables");

            migrationBuilder.DropTable(
                name: "ObservationLabResults");

            migrationBuilder.DropTable(
                name: "Patientdemographics");

            migrationBuilder.DropTable(
                name: "ServiceRequests");
        }
    }
}
