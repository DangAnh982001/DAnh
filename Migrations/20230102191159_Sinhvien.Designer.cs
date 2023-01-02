﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTVN.Migrations
{
    [DbContext(typeof(LTQLDbContext))]
    [Migration("20230102191159_Sinhvien")]
    partial class Sinhvien
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("BTVN.Models.LopHoc", b =>
                {
                    b.Property<int>("MaLop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaLop");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("BTVN.Models.Sinhvien", b =>
                {
                    b.Property<string>("Masinhvien")
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MaLop")
                        .HasColumnType("INTEGER");

                    b.HasKey("Masinhvien");

                    b.HasIndex("MaLop");

                    b.ToTable("Sinhvien");
                });

            modelBuilder.Entity("BTVN.Models.Sinhvien", b =>
                {
                    b.HasOne("BTVN.Models.LopHoc", "LopHoc")
                        .WithMany()
                        .HasForeignKey("MaLop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LopHoc");
                });
#pragma warning restore 612, 618
        }
    }
}
