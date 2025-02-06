﻿// <auto-generated />
using System;
using BioShopDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BioShopDB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250126145527_RenameTableToProducto")]
    partial class RenameTableToProducto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BioShop.Models.Informacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beneficios")
                        .HasColumnType("longtext");

                    b.Property<string>("ComoFunciona")
                        .HasColumnType("longtext");

                    b.Property<string>("Mision")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Informaciones");
                });

            modelBuilder.Entity("BioShopDB.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TiendaId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("TiendaId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TiendaId1");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("BioShopDB.Models.Tienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.Property<string>("Web")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tiendas");
                });

            modelBuilder.Entity("BioShopDB.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BioShopDB.Models.Producto", b =>
                {
                    b.HasOne("BioShopDB.Models.Tienda", null)
                        .WithMany("Productos")
                        .HasForeignKey("TiendaId1");
                });

            modelBuilder.Entity("BioShopDB.Models.Tienda", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
