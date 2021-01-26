﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using MusicStore.Models;
using System;

namespace MusicStore.Migrations
{
    [DbContext(typeof(MusicStoreContext))]
    [Migration("20181023071126_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("MusicStore.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlbumName");

                    b.Property<string>("Artist");

                    b.Property<string>("Notes");

                    b.HasKey("ID");

                    b.ToTable("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
