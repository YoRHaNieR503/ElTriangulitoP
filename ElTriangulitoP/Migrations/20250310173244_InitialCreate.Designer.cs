﻿// <auto-generated />
using System;
using ElTriangulitoP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElTriangulitoP.Migrations
{
    [DbContext(typeof(ElTriangulitoDBContext))]
    [Migration("20250310173244_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElTriangulitoP.Models.combos", b =>
                {
                    b.Property<int>("id_combo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_combo"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("tipo_plato_c")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("id_combo");

                    b.ToTable("combos");
                });

            modelBuilder.Entity("ElTriangulitoP.Models.detalle_orden", b =>
                {
                    b.Property<int>("id_detalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_detalle"));

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("id_combo")
                        .HasColumnType("int");

                    b.Property<int?>("id_plato")
                        .HasColumnType("int");

                    b.Property<int?>("id_promocion")
                        .HasColumnType("int");

                    b.Property<decimal>("subtotal")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("id_detalle");

                    b.HasIndex("id_combo");

                    b.HasIndex("id_plato");

                    b.HasIndex("id_promocion");

                    b.ToTable("detalle_orden");
                });

            modelBuilder.Entity("ElTriangulitoP.Models.mesas", b =>
                {
                    b.Property<int>("id_mesa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_mesa"));

                    b.Property<string>("estado_mesa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nombre_mesa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_mesa");

                    b.ToTable("mesas");
                });

            modelBuilder.Entity("ElTriangulitoP.Models.ordenes", b =>
                {
                    b.Property<int>("id_orden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_orden"));

                    b.Property<string>("comentario")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_detalle")
                        .HasColumnType("int");

                    b.Property<int>("id_mesa")
                        .HasColumnType("int");

                    b.Property<string>("nombre_cliente")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("id_orden");

                    b.HasIndex("id_detalle");

                    b.HasIndex("id_mesa");

                    b.ToTable("ordenes");
                });

            modelBuilder.Entity("ElTriangulitoP.Models.platos", b =>
                {
                    b.Property<int>("id_plato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_plato"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("tipo_plato")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("id_plato");

                    b.ToTable("platos");
                });

            modelBuilder.Entity("ElTriangulitoP.Models.promociones", b =>
                {
                    b.Property<int>("id_promocion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_promocion"));

                    b.Property<decimal?>("descuento")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime>("fecha_fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_inicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("id_combo")
                        .HasColumnType("int");

                    b.Property<int?>("id_plato")
                        .HasColumnType("int");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("id_promocion");

                    b.HasIndex("id_combo");

                    b.HasIndex("id_plato");

                    b.ToTable("promociones");
                });

            modelBuilder.Entity("ElTriangulitoP.Models.detalle_orden", b =>
                {
                    b.HasOne("ElTriangulitoP.Models.combos", "Combo")
                        .WithMany()
                        .HasForeignKey("id_combo");

                    b.HasOne("ElTriangulitoP.Models.platos", "Plato")
                        .WithMany()
                        .HasForeignKey("id_plato");

                    b.HasOne("ElTriangulitoP.Models.promociones", "Promocion")
                        .WithMany()
                        .HasForeignKey("id_promocion");

                    b.Navigation("Combo");

                    b.Navigation("Plato");

                    b.Navigation("Promocion");
                });

            modelBuilder.Entity("ElTriangulitoP.Models.ordenes", b =>
                {
                    b.HasOne("ElTriangulitoP.Models.detalle_orden", "DetalleOrden")
                        .WithMany()
                        .HasForeignKey("id_detalle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElTriangulitoP.Models.mesas", "Mesa")
                        .WithMany()
                        .HasForeignKey("id_mesa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetalleOrden");

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("ElTriangulitoP.Models.promociones", b =>
                {
                    b.HasOne("ElTriangulitoP.Models.combos", "Combo")
                        .WithMany()
                        .HasForeignKey("id_combo");

                    b.HasOne("ElTriangulitoP.Models.platos", "Plato")
                        .WithMany()
                        .HasForeignKey("id_plato");

                    b.Navigation("Combo");

                    b.Navigation("Plato");
                });
#pragma warning restore 612, 618
        }
    }
}
