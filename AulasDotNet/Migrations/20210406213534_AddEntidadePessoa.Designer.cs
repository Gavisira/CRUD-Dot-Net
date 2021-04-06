﻿// <auto-generated />
using System;
using AulasDotNet.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AulasDotNet.Migrations
{
    [DbContext(typeof(LocalDBContext))]
    [Migration("20210406213534_AddEntidadePessoa")]
    partial class AddEntidadePessoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AulasDotNet.Entities.Pessoa", b =>
                {
                    b.Property<int>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("_dtNascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("_nome")
                        .HasColumnType("text");

                    b.Property<string>("_nomeMae")
                        .HasColumnType("text");

                    b.HasKey("_id");

                    b.ToTable("pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
