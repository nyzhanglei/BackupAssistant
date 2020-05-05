﻿// <auto-generated />
using BackupAssistant.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackupAssistant.Core.Migrations
{
    [DbContext(typeof(BaContext))]
    partial class BaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("BackupAssistant.Core.Data.Provider", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProviderName")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProviderType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Settings")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });
#pragma warning restore 612, 618
        }
    }
}