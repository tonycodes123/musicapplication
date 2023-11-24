﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using musicdal;

#nullable disable

namespace ClassLibrary1.Migrations
{
    [DbContext(typeof(musicdbcontext))]
    [Migration("20231124061531_v4")]
    partial class v4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("musicdal.albumlist", b =>
                {
                    b.Property<int>("albumid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("albumid"), 1L, 1);

                    b.Property<string>("albumimage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("albumname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("albumid");

                    b.ToTable("albumlists");
                });

            modelBuilder.Entity("musicdal.singerlist", b =>
                {
                    b.Property<int>("singerid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("singerid"), 1L, 1);

                    b.Property<string>("singerimage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("singername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("singerid");

                    b.ToTable("singerlists");
                });

            modelBuilder.Entity("musicdal.songlist", b =>
                {
                    b.Property<int>("songid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("songid"), 1L, 1);

                    b.Property<int?>("singerlistsingerid")
                        .HasColumnType("int");

                    b.Property<string>("songname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("songreleasedate")
                        .HasColumnType("datetime2");

                    b.HasKey("songid");

                    b.HasIndex("singerlistsingerid");

                    b.ToTable("songlists");
                });

            modelBuilder.Entity("musicdal.songlist", b =>
                {
                    b.HasOne("musicdal.singerlist", null)
                        .WithMany("songid")
                        .HasForeignKey("singerlistsingerid");
                });

            modelBuilder.Entity("musicdal.singerlist", b =>
                {
                    b.Navigation("songid");
                });
#pragma warning restore 612, 618
        }
    }
}
