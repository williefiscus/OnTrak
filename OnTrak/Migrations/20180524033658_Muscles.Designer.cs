﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OnTrak.Models;
using System;

namespace OnTrak.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180524033658_Muscles")]
    partial class Muscles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnTrak.Models.Entities.Body.Muscle", b =>
                {
                    b.Property<int>("MuscleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BodyPartId");

                    b.Property<string>("Description");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name");

                    b.HasKey("MuscleId");

                    b.ToTable("Muscles");
                });

            modelBuilder.Entity("OnTrak.Models.Entities.BodyArea", b =>
                {
                    b.Property<int>("BodyAreaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name");

                    b.HasKey("BodyAreaId");

                    b.ToTable("BodyAreas");
                });

            modelBuilder.Entity("OnTrak.Models.Entities.BodyPart", b =>
                {
                    b.Property<int>("BodyPartId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BodyAreaId");

                    b.Property<string>("Description");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name");

                    b.HasKey("BodyPartId");

                    b.ToTable("BodyParts");
                });
#pragma warning restore 612, 618
        }
    }
}
