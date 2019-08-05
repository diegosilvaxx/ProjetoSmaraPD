﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmaraPD.Models;

namespace SmaraPD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190801153218_createFkCliente")]
    partial class createFkCliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmaraPD.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("Roles");

                    b.Property<string>("Senha");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("SmaraPD.Models.SalaReuniao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteForeignKey");

                    b.Property<DateTime>("DataEntrega");

                    b.Property<DateTime>("DataLocacao");

                    b.Property<string>("Sala");

                    b.HasKey("Id");

                    b.HasIndex("ClienteForeignKey");

                    b.ToTable("salaReunioes");
                });

            modelBuilder.Entity("SmaraPD.Models.SalaReuniao", b =>
                {
                    b.HasOne("SmaraPD.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteForeignKey")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
