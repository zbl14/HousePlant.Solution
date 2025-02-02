﻿// <auto-generated />
using HousePlant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HousePlant.Migrations
{
    [DbContext(typeof(HousePlantContext))]
    [Migration("20220816181557_validation")]
    partial class validation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HousePlant.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommonName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Humidity")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Propagation")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Soil")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sunlight")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TempMax")
                        .HasColumnType("int");

                    b.Property<int>("TempMin")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Water")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            CommonName = "AGAVE",
                            Description = "An agave plant comes in all different sizes and shapes; some are extremely  large and belong growing outside while the smaller varieties make perfect indoor potted houseplants. Agave plants are succulents with multi-layered rosettes of thick, fleshy, leaves. The short, thick stem is often hidden by the large, leathery leaves. If there are children and pets in the house, avoid purchasing agave plants that have sharp, pointed leaves with spiny margins. The sap in the agave leaves is very irritating and the spines and sharp points are painful if they puncture your skin. It takes many, many years for an agave plant to flower, especially when grown indoors. Some varieties may eventually produce a very tall stalk with clusters of flowers at the top. You may not want your agave plant to bloom since, strangely, they often die after flowering.",
                            Humidity = "drought resistance",
                            Name = "AGAVE PLANT",
                            Propagation = "Offset",
                            Soil = "succulent potting soil",
                            Sunlight = "bright light",
                            TempMax = 80,
                            TempMin = 65,
                            Type = "Earth",
                            Water = "every 2-3 weeks"
                        },
                        new
                        {
                            PlantId = 2,
                            CommonName = "African Violet Plant",
                            Description = "An African Violet plant  is a small, compact, short plant with soft, furry, thick, round or oval shaped leaves. The leaves grow close together, in a tight group, on long stems, at the base of the plant. An African Violet plant produces beautiful, delicate flowers with five, velvety petals. The flowers can be white, yellow, blue, violet, pink, or fuchsia. Some of the newer varieties have large double, and bi-colored flowers.",
                            Humidity = "high humidity",
                            Name = "Saintpaulia Ionantha",
                            Propagation = "leaf cuttings",
                            Soil = "rich, airy, potting mixture",
                            Sunlight = "bright indirect light",
                            TempMax = 80,
                            TempMin = 65,
                            Type = "Flowering",
                            Water = "Once 1-2 inches of soil is dry"
                        },
                        new
                        {
                            PlantId = 3,
                            CommonName = "African Mask plant",
                            Description = "An Alocasia plant, native to Asia and eastern Australia, is also called an Elephant Ear plant or African Mask plant because of its very large, glossy, heart-shaped leaves, some with very, wavy edges. The leaves may be as large as eight to thirty five inches (20cm-90cm) in length. This plant does produce flowers, but the flowers are small and insignificant and certainly pale in comparison to the beautiful plant leaves. In its native habitat, an alocasia plant grows on the floor of the forest which explains why it likes bright light, but direct sun burns the beautiful leaves.",
                            Humidity = "high humidity",
                            Name = "Alocasia",
                            Propagation = "plant division",
                            Soil = "well-aerated, fast draining, loose soil",
                            Sunlight = "very bright indirect light",
                            TempMax = 80,
                            TempMin = 60,
                            Type = "small flowers with bold leaf patterns",
                            Water = "Once top 2-3 inches of soil is dry"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
