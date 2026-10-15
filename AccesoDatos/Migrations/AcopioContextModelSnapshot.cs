using System;
using AccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccesoDatos.Migrations
{
    [DbContext(typeof(AcopioContext))]
    partial class AcopioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "10.0.13");

            modelBuilder.Entity("AccesoDatos.Entidades.Cereal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<double>("HumedadMaxima")
                        .HasColumnType("REAL");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cereales");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cuit")
                        .HasColumnType("TEXT");

                    b.Property<string>("Localidad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Descarga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CerealId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Humedad")
                        .HasColumnType("REAL");

                    b.Property<int>("KilosBrutos")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Patente")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tara")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CerealId");

                    b.HasIndex("ProductorId");

                    b.ToTable("Descargas");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Despacho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CerealId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("KilosBrutos")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Patente")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tara")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CerealId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Despachos");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Productor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cuit")
                        .HasColumnType("TEXT");

                    b.Property<string>("Localidad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Productores");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Descarga", b =>
                {
                    b.HasOne("AccesoDatos.Entidades.Cereal", "Cereal")
                        .WithMany("Descargas")
                        .HasForeignKey("CerealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccesoDatos.Entidades.Productor", "Productor")
                        .WithMany("Descargas")
                        .HasForeignKey("ProductorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cereal");

                    b.Navigation("Productor");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Despacho", b =>
                {
                    b.HasOne("AccesoDatos.Entidades.Cereal", "Cereal")
                        .WithMany("Despachos")
                        .HasForeignKey("CerealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccesoDatos.Entidades.Cliente", "Cliente")
                        .WithMany("Despachos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cereal");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Cereal", b =>
                {
                    b.Navigation("Descargas");

                    b.Navigation("Despachos");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Cliente", b =>
                {
                    b.Navigation("Despachos");
                });

            modelBuilder.Entity("AccesoDatos.Entidades.Productor", b =>
                {
                    b.Navigation("Descargas");
                });
#pragma warning restore 612, 618
        }
    }
}
