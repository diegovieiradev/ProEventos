﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProEventos.API.Data;

#nullable disable

namespace ProEventos.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221227181317_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("ProEventos.API.Models.Evento", b =>
                {
                    b.Property<int>("EventoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataEvento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagemURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tema")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EventoID");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}