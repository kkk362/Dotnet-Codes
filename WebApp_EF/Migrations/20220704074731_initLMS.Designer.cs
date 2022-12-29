﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp_EF.DataAccessLayer_EF;

namespace WebApp_EF.Migrations
{
    [DbContext(typeof(DataAccessLayer_LMS))]
    [Migration("20220704074731_initLMS")]
    partial class initLMS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApp_EF.Models.ManagerModel", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("M_Mobile_Number")
                        .HasColumnType("bigint");

                    b.HasKey("MId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("WebApp_EF.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile_Number")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
