﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication11.Models;

namespace WebApplication11.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication11.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accnumber");

                    b.Property<string>("Address");

                    b.Property<string>("Bankname");

                    b.Property<string>("Bloodgroup");

                    b.Property<string>("Branchcode");

                    b.Property<string>("Branchname");

                    b.Property<string>("Campus");

                    b.Property<string>("Cnic");

                    b.Property<string>("Code");

                    b.Property<DateTime>("Dateofbirth");

                    b.Property<string>("Designation");

                    b.Property<string>("Email");

                    b.Property<string>("EmpName");

                    b.Property<int>("Esinumber");

                    b.Property<string>("FatherName");

                    b.Property<string>("Gender");

                    b.Property<string>("Grade");

                    b.Property<DateTime>("Joiningdate");

                    b.Property<DateTime>("Labourcardexpirydate");

                    b.Property<string>("Labourcardno");

                    b.Property<string>("Maritalstatus");

                    b.Property<string>("Mobilenumber");

                    b.Property<string>("Naration");

                    b.Property<string>("Pannumber");

                    b.Property<DateTime>("Passportexpirydate");

                    b.Property<string>("Passportno");

                    b.Property<string>("Pfnumber");

                    b.Property<string>("Phonenumber");

                    b.Property<string>("Qualification");

                    b.Property<string>("Salarypackage");

                    b.Property<string>("Salarytype");

                    b.Property<string>("Subjectexpert");

                    b.Property<DateTime>("Terminationdate");

                    b.Property<string>("University");

                    b.Property<DateTime>("Visaexpirydate");

                    b.Property<string>("Visano");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
