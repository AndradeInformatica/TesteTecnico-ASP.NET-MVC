using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteTecnico.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypesPeople",
                columns: table => new
                {
                    TypePersonId = table.Column<byte>(nullable: false),
                    Description = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesPeople", x => x.TypePersonId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypePersonId = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_TypesPeople_TypePersonId",
                        column: x => x.TypePersonId,
                        principalTable: "TypesPeople",
                        principalColumn: "TypePersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(type: "varchar(50)", nullable: false),
                    Number = table.Column<string>(type: "varchar(15)", nullable: false),
                    Complement = table.Column<string>(type: "varchar(25)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(30)", nullable: false),
                    City = table.Column<string>(type: "varchar(40)", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(9)", nullable: false),
                    State = table.Column<string>(type: "char(2)", nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_People_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LegalPeople",
                columns: table => new
                {
                    LegalPersonId = table.Column<int>(nullable: false),
                    SocialName = table.Column<string>(type: "varchar(60)", nullable: false),
                    FantasyName = table.Column<string>(type: "varchar(25)", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(18)", nullable: false),
                    StateRegistration = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalPeople", x => x.LegalPersonId);
                    table.ForeignKey(
                        name: "FK_LegalPeople_People_LegalPersonId",
                        column: x => x.LegalPersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalsPeople",
                columns: table => new
                {
                    PhysicalPersonId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(type: "varchar(25)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(25)", nullable: false),
                    RG = table.Column<string>(type: "varchar(12)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalsPeople", x => x.PhysicalPersonId);
                    table.ForeignKey(
                        name: "FK_PhysicalsPeople_People_PhysicalPersonId",
                        column: x => x.PhysicalPersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonId",
                table: "Addresses",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_People_TypePersonId",
                table: "People",
                column: "TypePersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "LegalPeople");

            migrationBuilder.DropTable(
                name: "PhysicalsPeople");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "TypesPeople");
        }
    }
}
