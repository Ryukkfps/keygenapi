﻿// <auto-generated />
using System;
using KeyGen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KeyGen.Migrations
{
    [DbContext(typeof(KeyGeneratorDBContext))]
    partial class KeyGeneratorDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KeyGen.Models.AnswerKey", b =>
                {
                    b.Property<int>("AnswerKey_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<int>("Page_number")
                        .HasColumnType("int");

                    b.Property<string>("Paper_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Question_number")
                        .HasColumnType("int");

                    b.HasKey("AnswerKey_Id");

                    b.ToTable("AnswerKeys");
                });

            modelBuilder.Entity("KeyGen.Models.Course", b =>
                {
                    b.Property<int>("Course_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Course_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Course_Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("KeyGen.Models.ExamType", b =>
                {
                    b.Property<int>("Exam_Type_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Exam_Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("University_id")
                        .HasColumnType("int");

                    b.HasKey("Exam_Type_id");

                    b.ToTable("ExamTypes");
                });

            modelBuilder.Entity("KeyGen.Models.Module", b =>
                {
                    b.Property<int>("Module_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Module_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Module_Id");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("KeyGen.Models.Paper", b =>
                {
                    b.Property<int>("Paper_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Catch_Number")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("ExamType_Id")
                        .HasColumnType("int");

                    b.Property<string>("Paper_Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SessionType_Id")
                        .HasColumnType("int");

                    b.Property<int>("Subject_Id")
                        .HasColumnType("int");

                    b.Property<int>("University_Id")
                        .HasColumnType("int");

                    b.HasKey("Paper_Id");

                    b.ToTable("Papers");
                });

            modelBuilder.Entity("KeyGen.Models.Permission", b =>
                {
                    b.Property<int>("Permission_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Can_Add")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Can_Delete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Can_Update")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Can_View")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Module_Id")
                        .HasColumnType("int");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Permission_Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("KeyGen.Models.Session", b =>
                {
                    b.Property<int>("Session_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Session_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("University_id")
                        .HasColumnType("int");

                    b.HasKey("Session_Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("KeyGen.Models.Subject", b =>
                {
                    b.Property<int>("Subject_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Subject_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Subject_Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("KeyGen.Models.University", b =>
                {
                    b.Property<int>("University_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Session_Id")
                        .HasColumnType("int");

                    b.Property<string>("University_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("University_Id");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("KeyGen.Models.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Profile_pic")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UserCreatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("User_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KeyGen.Models.UserAuth", b =>
                {
                    b.Property<int>("User_Auth_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AutoGenPass")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("User_Auth_Id");

                    b.ToTable("UserAuthentication");
                });
#pragma warning restore 612, 618
        }
    }
}
