﻿// <auto-generated />
using System;
using ClassLibrary1;
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
    [Migration("20231123074931_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassLibrary1.albumlist", b =>
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

                    b.ToTable("albumlist");
                });

            modelBuilder.Entity("ClassLibrary1.singerlist", b =>
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

                    b.Property<int?>("songlistsongid")
                        .HasColumnType("int");

                    b.HasKey("singerid");

                    b.HasIndex("songlistsongid");

                    b.ToTable("singerlist");
                });

            modelBuilder.Entity("ClassLibrary1.songlist", b =>
                {
                    b.Property<int>("songid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("songid"), 1L, 1);

                    b.Property<string>("songname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("songreleasedate")
                        .HasColumnType("datetime2");

                    b.HasKey("songid");

                    b.ToTable("songlist");
                });

            modelBuilder.Entity("ClassLibrary1.singerlist", b =>
                {
                    b.HasOne("ClassLibrary1.songlist", null)
                        .WithMany("singerid")
                        .HasForeignKey("songlistsongid");
                });

            modelBuilder.Entity("ClassLibrary1.songlist", b =>
                {
                    b.Navigation("singerid");
                });
#pragma warning restore 612, 618
        }
    }
}
