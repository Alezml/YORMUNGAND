﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YORMUNGAND.Data;

namespace YORMUNGAND.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20210426133443_d491")]
    partial class d491
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccessPermissionsAccessRole", b =>
                {
                    b.Property<int>("ACCESSPERMISSIONSid")
                        .HasColumnType("int");

                    b.Property<int>("ACCESSROLEid")
                        .HasColumnType("int");

                    b.HasKey("ACCESSPERMISSIONSid", "ACCESSROLEid");

                    b.HasIndex("ACCESSROLEid");

                    b.ToTable("AccessPermissionsAccessRole");
                });

            modelBuilder.Entity("AccessRoleAccessUsers", b =>
                {
                    b.Property<int>("ACCESSROLEid")
                        .HasColumnType("int");

                    b.Property<int>("ACCESSUSERSid")
                        .HasColumnType("int");

                    b.HasKey("ACCESSROLEid", "ACCESSUSERSid");

                    b.HasIndex("ACCESSUSERSid");

                    b.ToTable("AccessRoleAccessUsers");
                });

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

            modelBuilder.Entity("YORMUNGAND.Data.Models.AccessUsers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DATE_LAST_SEEN")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DATE_REG")
                        .HasColumnType("datetime2");

                    b.Property<string>("MAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AccessUsers");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.Alert", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Blink")
                        .HasColumnType("bit");

                    b.Property<string>("Blinks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOLIST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ERROR_MSG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EVENT_TIME")
                        .HasColumnType("datetime2");

                    b.Property<string>("PROCES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TAG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WORKED")
                        .HasColumnType("bit");

                    b.Property<DateTime>("WORKED_TIME")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("RPAAlert");
                });

            modelBuilder.Entity("YORMUNGAND.Data.Models.CashBlock", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BLOCKED")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BLOCK_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("BLOCK_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("CashBlock");
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

            modelBuilder.Entity("YORMUNGAND.Data.Models.UserAgentLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LOGDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("USERAGENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USERNAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("UserAgentLog");
                });

            modelBuilder.Entity("AccessPermissionsAccessRole", b =>
                {
                    b.HasOne("YORMUNGAND.Data.Models.AccessPermissions", null)
                        .WithMany()
                        .HasForeignKey("ACCESSPERMISSIONSid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YORMUNGAND.Data.Models.AccessRole", null)
                        .WithMany()
                        .HasForeignKey("ACCESSROLEid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AccessRoleAccessUsers", b =>
                {
                    b.HasOne("YORMUNGAND.Data.Models.AccessRole", null)
                        .WithMany()
                        .HasForeignKey("ACCESSROLEid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YORMUNGAND.Data.Models.AccessUsers", null)
                        .WithMany()
                        .HasForeignKey("ACCESSUSERSid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("YORMUNGAND.Data.Models.QueueItemID", b =>
                {
                    b.Navigation("CESS76INT");
                });
#pragma warning restore 612, 618
        }
    }
}
