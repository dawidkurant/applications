﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Papu.Entities;

namespace Papu.Migrations
{
    [DbContext(typeof(PapuDbContext))]
    partial class PapuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Papu.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Papu.Entities.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DishDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("FridayId")
                        .HasColumnType("int");

                    b.Property<string>("MethodOfPeparation")
                        .IsRequired()
                        .HasMaxLength(1300)
                        .HasColumnType("nvarchar(1300)");

                    b.Property<int?>("MondayId")
                        .HasColumnType("int");

                    b.Property<int>("Portions")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("PreparationTime")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int?>("SaturdayId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int?>("SundayId")
                        .HasColumnType("int");

                    b.Property<int?>("ThursdayId")
                        .HasColumnType("int");

                    b.Property<int?>("TuesdayId")
                        .HasColumnType("int");

                    b.Property<int?>("WednesdayId")
                        .HasColumnType("int");

                    b.HasKey("DishId");

                    b.HasIndex("FridayId");

                    b.HasIndex("MondayId");

                    b.HasIndex("SaturdayId");

                    b.HasIndex("SundayId");

                    b.HasIndex("ThursdayId");

                    b.HasIndex("TuesdayId");

                    b.HasIndex("WednesdayId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Papu.Entities.Friday", b =>
                {
                    b.Property<int>("FridayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("FridayId");

                    b.ToTable("Fridays");
                });

            modelBuilder.Entity("Papu.Entities.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.HasIndex("ProductId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Papu.Entities.KindOf", b =>
                {
                    b.Property<int>("KindOfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("KindOfName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("KindOfId");

                    b.HasIndex("DishId");

                    b.ToTable("KindsOf");
                });

            modelBuilder.Entity("Papu.Entities.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FridayId")
                        .HasColumnType("int");

                    b.Property<string>("MenuDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MondayId")
                        .HasColumnType("int");

                    b.Property<int?>("SaturdayId")
                        .HasColumnType("int");

                    b.Property<int?>("SundayId")
                        .HasColumnType("int");

                    b.Property<int?>("ThursdayId")
                        .HasColumnType("int");

                    b.Property<int?>("TuesdayId")
                        .HasColumnType("int");

                    b.Property<int?>("WednesdayId")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.HasIndex("FridayId");

                    b.HasIndex("MondayId");

                    b.HasIndex("SaturdayId");

                    b.HasIndex("SundayId");

                    b.HasIndex("ThursdayId");

                    b.HasIndex("TuesdayId");

                    b.HasIndex("WednesdayId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Papu.Entities.Monday", b =>
                {
                    b.Property<int>("MondayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("MondayId");

                    b.ToTable("Mondays");
                });

            modelBuilder.Entity("Papu.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("DishId")
                        .HasColumnType("int");

                    b.Property<int?>("FridayId")
                        .HasColumnType("int");

                    b.Property<int?>("MondayId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SaturdayId")
                        .HasColumnType("int");

                    b.Property<int?>("SundayId")
                        .HasColumnType("int");

                    b.Property<int?>("ThursdayId")
                        .HasColumnType("int");

                    b.Property<int?>("TuesdayId")
                        .HasColumnType("int");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.Property<int?>("WednesdayId")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(7,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DishId");

                    b.HasIndex("FridayId");

                    b.HasIndex("MondayId");

                    b.HasIndex("SaturdayId");

                    b.HasIndex("SundayId");

                    b.HasIndex("ThursdayId");

                    b.HasIndex("TuesdayId");

                    b.HasIndex("UnitId");

                    b.HasIndex("WednesdayId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Papu.Entities.Saturday", b =>
                {
                    b.Property<int>("SaturdayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("SaturdayId");

                    b.ToTable("Saturdays");
                });

            modelBuilder.Entity("Papu.Entities.Sunday", b =>
                {
                    b.Property<int>("SundayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("SundayId");

                    b.ToTable("Sundays");
                });

            modelBuilder.Entity("Papu.Entities.Thursday", b =>
                {
                    b.Property<int>("ThursdayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ThursdayId");

                    b.ToTable("Thursdays");
                });

            modelBuilder.Entity("Papu.Entities.Tuesday", b =>
                {
                    b.Property<int>("TuesdayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("TuesdayId");

                    b.ToTable("Tuesdays");
                });

            modelBuilder.Entity("Papu.Entities.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TypeId");

                    b.HasIndex("DishId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Papu.Entities.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UnitId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Papu.Entities.Wednesday", b =>
                {
                    b.Property<int>("WednesdayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("WednesdayId");

                    b.ToTable("Wednesdays");
                });

            modelBuilder.Entity("Papu.Entities.Dish", b =>
                {
                    b.HasOne("Papu.Entities.Friday", null)
                        .WithMany("FridayDishes")
                        .HasForeignKey("FridayId");

                    b.HasOne("Papu.Entities.Monday", null)
                        .WithMany("MondayDishes")
                        .HasForeignKey("MondayId");

                    b.HasOne("Papu.Entities.Saturday", null)
                        .WithMany("SaturdayDishes")
                        .HasForeignKey("SaturdayId");

                    b.HasOne("Papu.Entities.Sunday", null)
                        .WithMany("SundayDishes")
                        .HasForeignKey("SundayId");

                    b.HasOne("Papu.Entities.Thursday", null)
                        .WithMany("ThursdayDishes")
                        .HasForeignKey("ThursdayId");

                    b.HasOne("Papu.Entities.Tuesday", null)
                        .WithMany("TuesdayDishes")
                        .HasForeignKey("TuesdayId");

                    b.HasOne("Papu.Entities.Wednesday", null)
                        .WithMany("WednesdayDishes")
                        .HasForeignKey("WednesdayId");
                });

            modelBuilder.Entity("Papu.Entities.Group", b =>
                {
                    b.HasOne("Papu.Entities.Product", null)
                        .WithMany("Groups")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Papu.Entities.KindOf", b =>
                {
                    b.HasOne("Papu.Entities.Dish", null)
                        .WithMany("KindsOf")
                        .HasForeignKey("DishId");
                });

            modelBuilder.Entity("Papu.Entities.Menu", b =>
                {
                    b.HasOne("Papu.Entities.Friday", "Friday")
                        .WithMany()
                        .HasForeignKey("FridayId");

                    b.HasOne("Papu.Entities.Monday", "Monday")
                        .WithMany()
                        .HasForeignKey("MondayId");

                    b.HasOne("Papu.Entities.Saturday", "Saturday")
                        .WithMany()
                        .HasForeignKey("SaturdayId");

                    b.HasOne("Papu.Entities.Sunday", "Sunday")
                        .WithMany()
                        .HasForeignKey("SundayId");

                    b.HasOne("Papu.Entities.Thursday", "Thursday")
                        .WithMany()
                        .HasForeignKey("ThursdayId");

                    b.HasOne("Papu.Entities.Tuesday", "Tuesday")
                        .WithMany()
                        .HasForeignKey("TuesdayId");

                    b.HasOne("Papu.Entities.Wednesday", "Wednesday")
                        .WithMany()
                        .HasForeignKey("WednesdayId");

                    b.Navigation("Friday");

                    b.Navigation("Monday");

                    b.Navigation("Saturday");

                    b.Navigation("Sunday");

                    b.Navigation("Thursday");

                    b.Navigation("Tuesday");

                    b.Navigation("Wednesday");
                });

            modelBuilder.Entity("Papu.Entities.Product", b =>
                {
                    b.HasOne("Papu.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Papu.Entities.Dish", "Dish")
                        .WithMany("Products")
                        .HasForeignKey("DishId");

                    b.HasOne("Papu.Entities.Friday", null)
                        .WithMany("FridayProducts")
                        .HasForeignKey("FridayId");

                    b.HasOne("Papu.Entities.Monday", null)
                        .WithMany("MondayProducts")
                        .HasForeignKey("MondayId");

                    b.HasOne("Papu.Entities.Saturday", null)
                        .WithMany("SaturdayProducts")
                        .HasForeignKey("SaturdayId");

                    b.HasOne("Papu.Entities.Sunday", null)
                        .WithMany("SundayProducts")
                        .HasForeignKey("SundayId");

                    b.HasOne("Papu.Entities.Thursday", null)
                        .WithMany("ThursdayProducts")
                        .HasForeignKey("ThursdayId");

                    b.HasOne("Papu.Entities.Tuesday", null)
                        .WithMany("TuesdayProducts")
                        .HasForeignKey("TuesdayId");

                    b.HasOne("Papu.Entities.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId");

                    b.HasOne("Papu.Entities.Wednesday", null)
                        .WithMany("WednesdayProducts")
                        .HasForeignKey("WednesdayId");

                    b.Navigation("Category");

                    b.Navigation("Dish");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Papu.Entities.Type", b =>
                {
                    b.HasOne("Papu.Entities.Dish", null)
                        .WithMany("Types")
                        .HasForeignKey("DishId");
                });

            modelBuilder.Entity("Papu.Entities.Dish", b =>
                {
                    b.Navigation("KindsOf");

                    b.Navigation("Products");

                    b.Navigation("Types");
                });

            modelBuilder.Entity("Papu.Entities.Friday", b =>
                {
                    b.Navigation("FridayDishes");

                    b.Navigation("FridayProducts");
                });

            modelBuilder.Entity("Papu.Entities.Monday", b =>
                {
                    b.Navigation("MondayDishes");

                    b.Navigation("MondayProducts");
                });

            modelBuilder.Entity("Papu.Entities.Product", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("Papu.Entities.Saturday", b =>
                {
                    b.Navigation("SaturdayDishes");

                    b.Navigation("SaturdayProducts");
                });

            modelBuilder.Entity("Papu.Entities.Sunday", b =>
                {
                    b.Navigation("SundayDishes");

                    b.Navigation("SundayProducts");
                });

            modelBuilder.Entity("Papu.Entities.Thursday", b =>
                {
                    b.Navigation("ThursdayDishes");

                    b.Navigation("ThursdayProducts");
                });

            modelBuilder.Entity("Papu.Entities.Tuesday", b =>
                {
                    b.Navigation("TuesdayDishes");

                    b.Navigation("TuesdayProducts");
                });

            modelBuilder.Entity("Papu.Entities.Wednesday", b =>
                {
                    b.Navigation("WednesdayDishes");

                    b.Navigation("WednesdayProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
