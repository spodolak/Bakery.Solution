﻿// <auto-generated />
using Bakery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bakery.Migrations
{
    [DbContext(typeof(BakeryContext))]
    [Migration("20200327173124_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bakery.Models.Flavor", b =>
                {
                    b.Property<int>("FlavorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("FlavorId");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("Bakery.Models.FlavorTreat", b =>
                {
                    b.Property<int>("FlavorTreatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FlavorId");

                    b.Property<int>("TreatId");

                    b.HasKey("FlavorTreatId");

                    b.HasIndex("FlavorId");

                    b.HasIndex("TreatId");

                    b.ToTable("FlavorTreat");
                });

            modelBuilder.Entity("Bakery.Models.Treat", b =>
                {
                    b.Property<int>("TreatId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("TreatId");

                    b.ToTable("Treats");
                });

            modelBuilder.Entity("Bakery.Models.FlavorTreat", b =>
                {
                    b.HasOne("Bakery.Models.Flavor", "Flavor")
                        .WithMany("Treats")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bakery.Models.Treat", "Treat")
                        .WithMany("Flavors")
                        .HasForeignKey("TreatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
