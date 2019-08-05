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
    [Migration("20190801131639_add_Autorizacao")]
    partial class add_Autorizacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmaraPD.Models.SalaReuniao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente");

                    b.Property<DateTime>("DataEntrega");

                    b.Property<DateTime>("DataLocacao");

                    b.Property<string>("Roles");

                    b.Property<string>("Sala");

                    b.HasKey("Id");

                    b.ToTable("salaReunioes");
                });
#pragma warning restore 612, 618
        }
    }
}
