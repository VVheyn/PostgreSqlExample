﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgreSqlExample.Data;

namespace PostgreSqlExample.Data.Migrations
{
    [DbContext(typeof(PostgresqlExampleDbContext))]
    [Migration("20211025130115_AddedFirstMigration")]
    partial class AddedFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PostgreSqlExample.Data.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(600)")
                        .HasMaxLength(600);

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Article");
                });
#pragma warning restore 612, 618
        }
    }
}
