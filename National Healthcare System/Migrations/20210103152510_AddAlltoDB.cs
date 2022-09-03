using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace National_Healthcare_System.Migrations
{
    public partial class AddAlltoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    Middle_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Fathers_Name = table.Column<string>(nullable: true),
                    Father_NID_Number = table.Column<string>(nullable: true),
                    Mothers_Name = table.Column<string>(nullable: true),
                    Mother_NID_Number = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Permanent_Address = table.Column<string>(nullable: true),
                    Current_Address = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Maritual_status = table.Column<string>(nullable: true),
                    Identity_Number = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Blood_Group = table.Column<string>(nullable: true),
                    ProfilePicture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Organization_Id = table.Column<Guid>(nullable: false),
                    Organization_Name = table.Column<string>(nullable: false),
                    Registration_No = table.Column<string>(nullable: false),
                    Organization_Address = table.Column<string>(nullable: false),
                    Organization_Contact = table.Column<string>(maxLength: 11, nullable: false),
                    Organization_Type = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Organization_Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Doctor_Id = table.Column<Guid>(nullable: false),
                    Identity_Number = table.Column<string>(nullable: true),
                    Registration_Number = table.Column<int>(nullable: false),
                    Institution_Name = table.Column<string>(nullable: false),
                    Doctor_Type = table.Column<string>(nullable: false),
                    Specialist = table.Column<bool>(nullable: false),
                    Consultation_Address = table.Column<string>(nullable: false),
                    Consultation_Contact = table.Column<string>(maxLength: 11, nullable: false),
                    Organization_Id = table.Column<Guid>(nullable: false),
                    Descriptions = table.Column<string>(nullable: false),
                    Verified = table.Column<bool>(nullable: false),
                    Organization_Id1 = table.Column<Guid>(nullable: true),
                    UsersId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Doctor_Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Organization_Organization_Id1",
                        column: x => x.Organization_Id1,
                        principalTable: "Organization",
                        principalColumn: "Organization_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctor_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation",
                columns: table => new
                {
                    Consultation_Id = table.Column<Guid>(nullable: false),
                    Doctor_Id = table.Column<Guid>(nullable: false),
                    Consultation_DateTime = table.Column<DateTime>(nullable: false),
                    Identity_Number = table.Column<string>(maxLength: 13, nullable: true),
                    Comment = table.Column<string>(nullable: false),
                    Doctor_Id1 = table.Column<Guid>(nullable: true),
                    UsersId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation", x => x.Consultation_Id);
                    table.ForeignKey(
                        name: "FK_Consultation_Doctor_Doctor_Id1",
                        column: x => x.Doctor_Id1,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctor_Schedule",
                columns: table => new
                {
                    Schedule_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Id = table.Column<Guid>(nullable: false),
                    Day = table.Column<string>(nullable: false),
                    Start_Time = table.Column<DateTime>(nullable: false),
                    End_Time = table.Column<DateTime>(nullable: false),
                    Organization_Name = table.Column<string>(nullable: false),
                    Chamber_Address = table.Column<string>(nullable: true),
                    Doctor_Id1 = table.Column<Guid>(nullable: true),
                    Organization_Id = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor_Schedule", x => x.Schedule_Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Schedule_Doctor_Doctor_Id1",
                        column: x => x.Doctor_Id1,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctor_Schedule_Organization_Organization_Id",
                        column: x => x.Organization_Id,
                        principalTable: "Organization",
                        principalColumn: "Organization_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostic",
                columns: table => new
                {
                    Diagnostic_Id = table.Column<Guid>(nullable: false),
                    Consultation_Id = table.Column<Guid>(nullable: false),
                    DateOfDiagnose = table.Column<DateTime>(nullable: false),
                    Diagnostic_Type = table.Column<string>(nullable: false),
                    Diagnostics = table.Column<string>(nullable: false),
                    Organization_Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Consultation_Id1 = table.Column<Guid>(nullable: true),
                    Organization_Id1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostic", x => x.Diagnostic_Id);
                    table.ForeignKey(
                        name: "FK_Diagnostic_Consultation_Consultation_Id1",
                        column: x => x.Consultation_Id1,
                        principalTable: "Consultation",
                        principalColumn: "Consultation_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnostic_Organization_Organization_Id1",
                        column: x => x.Organization_Id1,
                        principalTable: "Organization",
                        principalColumn: "Organization_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Prescription_Id = table.Column<Guid>(nullable: false),
                    Consultation_Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: false),
                    Consultation_Id1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Prescription_Id);
                    table.ForeignKey(
                        name: "FK_Prescription_Consultation_Consultation_Id1",
                        column: x => x.Consultation_Id1,
                        principalTable: "Consultation",
                        principalColumn: "Consultation_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medication",
                columns: table => new
                {
                    Medication_Id = table.Column<Guid>(nullable: false),
                    Prescription_Id = table.Column<Guid>(nullable: false),
                    DateOfMedication = table.Column<DateTime>(nullable: false),
                    Medications = table.Column<string>(nullable: false),
                    Prescription_Id1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medication", x => x.Medication_Id);
                    table.ForeignKey(
                        name: "FK_Medication_Prescription_Prescription_Id1",
                        column: x => x.Prescription_Id1,
                        principalTable: "Prescription",
                        principalColumn: "Prescription_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_Doctor_Id1",
                table: "Consultation",
                column: "Doctor_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_UsersId",
                table: "Consultation",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostic_Consultation_Id1",
                table: "Diagnostic",
                column: "Consultation_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostic_Organization_Id1",
                table: "Diagnostic",
                column: "Organization_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Organization_Id1",
                table: "Doctor",
                column: "Organization_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_UsersId",
                table: "Doctor",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Schedule_Doctor_Id1",
                table: "Doctor_Schedule",
                column: "Doctor_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Schedule_Organization_Id",
                table: "Doctor_Schedule",
                column: "Organization_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Medication_Prescription_Id1",
                table: "Medication",
                column: "Prescription_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Consultation_Id1",
                table: "Prescription",
                column: "Consultation_Id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Diagnostic");

            migrationBuilder.DropTable(
                name: "Doctor_Schedule");

            migrationBuilder.DropTable(
                name: "Medication");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Consultation");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
