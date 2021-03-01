﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YORMUNGAND.Data;

namespace YORMUNGAND.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessPermissions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERMISSION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AccessPermissions");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessRole", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ROLE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AccessRole");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessRolePermissions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ACCESSPERMISSIONSid")
                        .HasColumnType("int");

                    b.Property<int?>("ACCESSROLEid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ACCESSPERMISSIONSid");

                    b.HasIndex("ACCESSROLEid");

                    b.ToTable("AccessRolePermissions");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessUserRole", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ACCESSROLEid")
                        .HasColumnType("int");

                    b.Property<int?>("ACCESSUSERSid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ACCESSROLEid");

                    b.HasIndex("ACCESSUSERSid");

                    b.ToTable("AccessUserRole");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessUsers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AccessUsers");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.Cess76Int", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CHOICE_DATETIME")
                        .HasColumnType("datetime2");

                    b.Property<string>("CHOICE_STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QUEUEITEMID_REF")
                        .HasColumnType("int");

                    b.Property<string>("RESPONSIBLE_FOR_CHOICE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("QUEUEITEMID_REF")
                        .IsUnique();

                    b.ToTable("Cess76Ints");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.QueueItemID", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COMPANY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONTRACT_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONTRACT_N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DIADOK_FILE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DIADOK_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DIADOK_REF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DIADOK_SIGN_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DIADOK_UPLOAD_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DIRECTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOG_N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DS_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DS_N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECM_REF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ERROR1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ERROR2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EXPECTED_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FILIAL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GEO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GFK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMS_LINK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INITIATOR_FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INITIATOR_MAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KEY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRI_BS_N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRI_BS_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRI_CODE_PROJECT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRI_CODE_PROJECT_LIST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRI_DOUBLE_OF_PROJECT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRI_KT_CMP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRI_REF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P2P")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROVIDER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROVIDER_INN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PR_FILE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PR_N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PR_STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REGION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REQUIRED_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RESPONSIBLE_CHOISE_REASON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RESPONSIBLE_FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RESPONSIBLE_MAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SEVD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SEVD_N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TASK_LIST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TAX_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TECH_ERROR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VENDOR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_ATTORNEY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_COMMENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_DIAP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_DOC_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_DOP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_DOP_N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_END_WORK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_FILE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_INTEGRATION_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_PAY_CONDITIONS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_PSDC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_REF_TAB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_START_WORK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIR_SUMM_WO_NDS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZM_LOT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZM_N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZM_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("QueueItemIDs");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessRolePermissions", b =>
                {
                    b.HasOne("YORMUNGAND.Data.Models.AccessPermissions", "ACCESSPERMISSIONS")
                        .WithMany("ACCESSROLEPERMISSIONS")
                        .HasForeignKey("ACCESSPERMISSIONSid");

                    b.HasOne("YORMUNGAND.Data.Models.AccessRole", "ACCESSROLE")
                        .WithMany("ACCESSROLEPERMISSIONS")
                        .HasForeignKey("ACCESSROLEid");

                    b.Navigation("ACCESSPERMISSIONS");

                    b.Navigation("ACCESSROLE");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessUserRole", b =>
                {
                    b.HasOne("YORMUNGAND.Data.Models.AccessRole", "ACCESSROLE")
                        .WithMany("ACCESSUSERROLE")
                        .HasForeignKey("ACCESSROLEid");

                    b.HasOne("YORMUNGAND.Data.Models.AccessUsers", "ACCESSUSERS")
                        .WithMany("ACCESSUSERROLE")
                        .HasForeignKey("ACCESSUSERSid");

                    b.Navigation("ACCESSROLE");

                    b.Navigation("ACCESSUSERS");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.Cess76Int", b =>
                {
                    b.HasOne("YORMUNGAND.Data.Models.QueueItemID", "QUEUEITEMID")
                        .WithOne("CESS76INT")
                        .HasForeignKey("YORMUNGAND.Data.Models.Cess76Int", "QUEUEITEMID_REF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QUEUEITEMID");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessPermissions", b =>
                {
                    b.Navigation("ACCESSROLEPERMISSIONS");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessRole", b =>
                {
                    b.Navigation("ACCESSROLEPERMISSIONS");

                    b.Navigation("ACCESSUSERROLE");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessUsers", b =>
                {
                    b.Navigation("ACCESSUSERROLE");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.QueueItemID", b =>
                {
                    b.Navigation("CESS76INT");
                });
#pragma warning restore 612, 618
        }
    }
}
