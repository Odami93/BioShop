﻿// <auto-generated />
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
    [Migration("20250126123855_AgregarColumnaWeb")]
    partial class AgregarColumnaWeb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BioShopDB.Models.Evaluar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("Puntuación")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Evaluaciones");
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

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("TiendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TiendaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("BioShopDB.Models.Tienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

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
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Web")
                        .IsRequired()
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

            modelBuilder.Entity("BioShopDB.Models.Evaluar", b =>
                {
                    b.HasOne("BioShopDB.Models.Producto", "Producto")
                        .WithMany("Evaluaciones")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BioShopDB.Models.Usuario", "Usuario")
                        .WithMany("Evaluaciones")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BioShopDB.Models.Producto", b =>
                {
                    b.HasOne("BioShopDB.Models.Tienda", null)
                        .WithMany("Productos")
                        .HasForeignKey("TiendaId");
                });

            modelBuilder.Entity("BioShopDB.Models.Producto", b =>
                {
                    b.Navigation("Evaluaciones");
                });

            modelBuilder.Entity("BioShopDB.Models.Tienda", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("BioShopDB.Models.Usuario", b =>
                {
                    b.Navigation("Evaluaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
