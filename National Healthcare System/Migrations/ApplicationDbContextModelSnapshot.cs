// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using National_Healthcare_System.Data;

namespace National_Healthcare_System.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Consultation", b =>
                {
                    b.Property<Guid>("Consultation_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Consultation_DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Doctor_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Doctorid")
                        .HasColumnType("int");

                    b.Property<string>("Identity_Number")
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Consultation_Id");

                    b.HasIndex("Doctorid");

                    b.HasIndex("UsersId");

                    b.ToTable("Consultation");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Diagnostic", b =>
                {
                    b.Property<Guid>("Diagnostic_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Consultation_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Consultation_Id1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfDiagnose")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnostic_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diagnostics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Organization_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Organization_Id1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Diagnostic_Id");

                    b.HasIndex("Consultation_Id1");

                    b.HasIndex("Organization_Id1");

                    b.ToTable("Diagnostic");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Doctor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Consultation_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Consultation_Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Descriptions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Doctor_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Doctor_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Organization_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Organization_Id1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Registration_Number")
                        .HasColumnType("int");

                    b.Property<bool>("Specialist")
                        .HasColumnType("bit");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("Organization_Id1");

                    b.HasIndex("UsersId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Doctor_Schedule", b =>
                {
                    b.Property<int>("Schedule_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chamber_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Doctor_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Doctorid")
                        .HasColumnType("int");

                    b.Property<DateTime>("End_Time")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("Organization_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Organization_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start_Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Schedule_Id");

                    b.HasIndex("Doctorid");

                    b.HasIndex("Organization_Id");

                    b.ToTable("Doctor_Schedule");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Medication", b =>
                {
                    b.Property<Guid>("Medication_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfMedication")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Prescription_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Prescription_Id1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Medication_Id");

                    b.HasIndex("Prescription_Id1");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Organization", b =>
                {
                    b.Property<Guid>("Organization_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization_Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Organization_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registration_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Organization_Id");

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Prescription", b =>
                {
                    b.Property<Guid>("Prescription_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Consultation_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Consultation_Id1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Prescription_Id");

                    b.HasIndex("Consultation_Id1");

                    b.ToTable("Prescription");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Users", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Blood_Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Current_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Father_NID_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fathers_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maritual_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Middle_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mother_NID_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mothers_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permanent_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Consultation", b =>
                {
                    b.HasOne("National_Healthcare_System.Models.Doctor", "Doctor")
                        .WithMany("Consultations")
                        .HasForeignKey("Doctorid");

                    b.HasOne("National_Healthcare_System.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Diagnostic", b =>
                {
                    b.HasOne("National_Healthcare_System.Models.Consultation", "Consultation")
                        .WithMany()
                        .HasForeignKey("Consultation_Id1");

                    b.HasOne("National_Healthcare_System.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("Organization_Id1");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Doctor", b =>
                {
                    b.HasOne("National_Healthcare_System.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("Organization_Id1");

                    b.HasOne("National_Healthcare_System.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Doctor_Schedule", b =>
                {
                    b.HasOne("National_Healthcare_System.Models.Doctor", "Doctor")
                        .WithMany("Schedule")
                        .HasForeignKey("Doctorid");

                    b.HasOne("National_Healthcare_System.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("Organization_Id");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Medication", b =>
                {
                    b.HasOne("National_Healthcare_System.Models.Prescription", "Prescription")
                        .WithMany()
                        .HasForeignKey("Prescription_Id1");
                });

            modelBuilder.Entity("National_Healthcare_System.Models.Prescription", b =>
                {
                    b.HasOne("National_Healthcare_System.Models.Consultation", "Consultation")
                        .WithMany()
                        .HasForeignKey("Consultation_Id1");
                });
#pragma warning restore 612, 618
        }
    }
}
