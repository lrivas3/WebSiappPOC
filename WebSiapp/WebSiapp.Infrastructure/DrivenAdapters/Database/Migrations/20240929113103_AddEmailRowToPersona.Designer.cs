﻿// <auto-generated />
using System;
using WebSiapp.Infrastructure.DrivenAdapters.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebSiapp.Infrastructure.DrivenAdapters.Database.Migrations
{
    [DbContext(typeof(PruebaConceptoContext))]
    [Migration("20240929113103_AddEmailRowToPersona")]
    partial class AddEmailRowToPersona
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.1.24451.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebSiapp.Infrastructure.DrivenAdapters.Database.Entities.EmpresaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("WebSiapp.Infrastructure.DrivenAdapters.Database.Entities.PersonaEmpresaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmpresaEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaContrato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaFinContrato")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("PersonaEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaEntityId");

                    b.HasIndex("PersonaEntityId");

                    b.ToTable("PersonaEmpresa");
                });

            modelBuilder.Entity("WebSiapp.Infrastructure.DrivenAdapters.Database.Entities.PersonaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ocupación")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("WebSiapp.Infrastructure.DrivenAdapters.Database.Entities.PersonaEmpresaEntity", b =>
                {
                    b.HasOne("WebSiapp.Infrastructure.DrivenAdapters.Database.Entities.EmpresaEntity", "EmpresaEntity")
                        .WithMany()
                        .HasForeignKey("EmpresaEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebSiapp.Infrastructure.DrivenAdapters.Database.Entities.PersonaEntity", "PersonaEntity")
                        .WithMany()
                        .HasForeignKey("PersonaEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpresaEntity");

                    b.Navigation("PersonaEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
