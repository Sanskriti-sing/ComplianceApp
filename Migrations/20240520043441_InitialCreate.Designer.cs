﻿// <auto-generated />
using ComplianceApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ComplianceApp.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20240520043441_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ComplianceApp.Models.ComplianceItem", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("integer");

                    b.Property<int>("StartTime")
                        .HasColumnType("integer");

                    b.Property<int>("EndTime")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EpisodeId", "StartTime", "EndTime");

                    b.ToTable("ComplianceItems");
                });

            modelBuilder.Entity("ComplianceApp.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("ComplianceApp.Models.ComplianceItem", b =>
                {
                    b.HasOne("ComplianceApp.Models.Episode", null)
                        .WithMany("ComplianceItems")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComplianceApp.Models.Episode", b =>
                {
                    b.Navigation("ComplianceItems");
                });
#pragma warning restore 612, 618
        }
    }
}
