﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OutOfOffice.Persistence;

#nullable disable

namespace OutOfOffice.Persistence.Migrations
{
    [DbContext(typeof(RepositoryOutOfOfficeDbContext))]
    partial class RepositoryOutOfOfficeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.ApprovalRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ApproverId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("LeaveRequestId")
                        .HasColumnType("char(36)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApproverId");

                    b.HasIndex("LeaveRequestId");

                    b.HasIndex("StatusId");

                    b.ToTable("ApprovalRequests");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OutOfOfficeBalance")
                        .HasColumnType("int");

                    b.Property<Guid?>("PeoplePartnerId")
                        .HasColumnType("char(36)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("longblob");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("SubdivisionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PeoplePartnerId");

                    b.HasIndex("PositionId");

                    b.HasIndex("StatusId");

                    b.HasIndex("SubdivisionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.LeaveRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AbsenceReasonId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AbsenceReasonId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("StatusId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.LookUpTables.AbsenceReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AbsenceReasons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Vacation"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sick Leave"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Business Trip"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Paternity Leave"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Maternity Leave"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Unpaid Leave"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.LookUpTables.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Junior Developer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Middle Developer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Senior Developer"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Team Lead"
                        },
                        new
                        {
                            Id = 5,
                            Name = "HR Manager"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Project Manager"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Business Analyst"
                        },
                        new
                        {
                            Id = 8,
                            Name = "QA Engineer"
                        });
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.LookUpTables.ProjectStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ProjectStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Completed"
                        },
                        new
                        {
                            Id = 3,
                            Name = "On Hold"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cancelled"
                        });
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.LookUpTables.ProjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ProjectTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Internal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "External"
                        },
                        new
                        {
                            Id = 3,
                            Name = "R&D"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Maintenance"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Development"
                        });
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.LookUpTables.RequestStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("RequestStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cancelled"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Approved"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rejected"
                        },
                        new
                        {
                            Id = 4,
                            Name = "New"
                        });
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.LookUpTables.Subdivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Subdivisions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Development"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "QA"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Management"
                        });
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EndDate")
                        .HasColumnType("longtext");

                    b.Property<Guid>("ProjectManagerId")
                        .HasColumnType("char(36)");

                    b.Property<int>("ProjectTypeId")
                        .HasColumnType("int");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectManagerId");

                    b.HasIndex("ProjectTypeId");

                    b.HasIndex("StatusId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.ProjectEmployee", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.HasKey("ProjectId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ProjectEmployee");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.ApprovalRequest", b =>
                {
                    b.HasOne("OutOfOffice.Domain.Models.Entities.Employee", "Approver")
                        .WithMany()
                        .HasForeignKey("ApproverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.LeaveRequest", "LeaveRequest")
                        .WithMany()
                        .HasForeignKey("LeaveRequestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.LookUpTables.RequestStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Approver");

                    b.Navigation("LeaveRequest");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.Employee", b =>
                {
                    b.HasOne("OutOfOffice.Domain.Models.Entities.Employee", "PeoplePartner")
                        .WithMany()
                        .HasForeignKey("PeoplePartnerId");

                    b.HasOne("OutOfOffice.Domain.Models.Entities.LookUpTables.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.LookUpTables.RequestStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.LookUpTables.Subdivision", "Subdivision")
                        .WithMany()
                        .HasForeignKey("SubdivisionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PeoplePartner");

                    b.Navigation("Position");

                    b.Navigation("Status");

                    b.Navigation("Subdivision");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.LeaveRequest", b =>
                {
                    b.HasOne("OutOfOffice.Domain.Models.Entities.LookUpTables.AbsenceReason", "AbsenceReason")
                        .WithMany()
                        .HasForeignKey("AbsenceReasonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.LookUpTables.RequestStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AbsenceReason");

                    b.Navigation("Employee");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.Project", b =>
                {
                    b.HasOne("OutOfOffice.Domain.Models.Entities.Employee", "ProjectManager")
                        .WithMany()
                        .HasForeignKey("ProjectManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.LookUpTables.ProjectType", "ProjectType")
                        .WithMany()
                        .HasForeignKey("ProjectTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.LookUpTables.ProjectStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProjectManager");

                    b.Navigation("ProjectType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.ProjectEmployee", b =>
                {
                    b.HasOne("OutOfOffice.Domain.Models.Entities.Employee", "Employee")
                        .WithMany("ProjectEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Domain.Models.Entities.Project", "Project")
                        .WithMany("ProjectEmployees")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.Employee", b =>
                {
                    b.Navigation("ProjectEmployees");
                });

            modelBuilder.Entity("OutOfOffice.Domain.Models.Entities.Project", b =>
                {
                    b.Navigation("ProjectEmployees");
                });
#pragma warning restore 612, 618
        }
    }
}
