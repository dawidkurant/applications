﻿// <auto-generated />
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

            modelBuilder.Entity("Papu.Entities.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FridayId")
                        .HasColumnType("int");

                    b.Property<string>("MethodOfPeparation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MondayId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Portions")
                        .HasColumnType("int");

                    b.Property<int>("PreparationTime")
                        .HasColumnType("int");

                    b.Property<int>("SaturdayId")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SundayId")
                        .HasColumnType("int");

                    b.Property<int>("ThursdayId")
                        .HasColumnType("int");

                    b.Property<int>("TuesdayId")
                        .HasColumnType("int");

                    b.Property<int>("WednesdayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Fridays");
                });

            modelBuilder.Entity("Papu.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Papu.Entities.KindOf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.ToTable("KindsOf");
                });

            modelBuilder.Entity("Papu.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FridayId")
                        .HasColumnType("int");

                    b.Property<int>("MondayId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SaturdayId")
                        .HasColumnType("int");

                    b.Property<int>("SundayId")
                        .HasColumnType("int");

                    b.Property<int>("ThursdayId")
                        .HasColumnType("int");

                    b.Property<int>("TuesdayId")
                        .HasColumnType("int");

                    b.Property<int>("WednesdayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FridayId")
                        .IsUnique();

                    b.HasIndex("MondayId")
                        .IsUnique();

                    b.HasIndex("SaturdayId")
                        .IsUnique();

                    b.HasIndex("SundayId")
                        .IsUnique();

                    b.HasIndex("ThursdayId")
                        .IsUnique();

                    b.HasIndex("TuesdayId")
                        .IsUnique();

                    b.HasIndex("WednesdayId")
                        .IsUnique();

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Papu.Entities.Monday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Mondays");
                });

            modelBuilder.Entity("Papu.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("FridayId")
                        .HasColumnType("int");

                    b.Property<int>("MondayId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SaturdayId")
                        .HasColumnType("int");

                    b.Property<int>("SundayId")
                        .HasColumnType("int");

                    b.Property<int>("ThursdayId")
                        .HasColumnType("int");

                    b.Property<int>("TuesdayId")
                        .HasColumnType("int");

                    b.Property<int>("WednesdayId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("FridayId");

                    b.HasIndex("MondayId");

                    b.HasIndex("SaturdayId");

                    b.HasIndex("SundayId");

                    b.HasIndex("ThursdayId");

                    b.HasIndex("TuesdayId");

                    b.HasIndex("WednesdayId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Papu.Entities.Saturday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Saturdays");
                });

            modelBuilder.Entity("Papu.Entities.Sunday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Sundays");
                });

            modelBuilder.Entity("Papu.Entities.Thursday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Thursdays");
                });

            modelBuilder.Entity("Papu.Entities.Tuesday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Tuesdays");
                });

            modelBuilder.Entity("Papu.Entities.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Papu.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Papu.Entities.Wednesday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Wednesdays");
                });

            modelBuilder.Entity("Papu.Entities.Dish", b =>
                {
                    b.HasOne("Papu.Entities.Friday", "Friday")
                        .WithMany("Dishes")
                        .HasForeignKey("FridayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Monday", "Monday")
                        .WithMany("Dishes")
                        .HasForeignKey("MondayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Saturday", "Saturday")
                        .WithMany("Dishes")
                        .HasForeignKey("SaturdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Sunday", "Sunday")
                        .WithMany("Dishes")
                        .HasForeignKey("SundayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Thursday", "Thursday")
                        .WithMany("Dishes")
                        .HasForeignKey("ThursdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Tuesday", "Tuesday")
                        .WithMany("Dishes")
                        .HasForeignKey("TuesdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Wednesday", "Wednesday")
                        .WithMany("Dishes")
                        .HasForeignKey("WednesdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Friday");

                    b.Navigation("Monday");

                    b.Navigation("Saturday");

                    b.Navigation("Sunday");

                    b.Navigation("Thursday");

                    b.Navigation("Tuesday");

                    b.Navigation("Wednesday");
                });

            modelBuilder.Entity("Papu.Entities.Group", b =>
                {
                    b.HasOne("Papu.Entities.Product", "Product")
                        .WithMany("Groups")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Papu.Entities.KindOf", b =>
                {
                    b.HasOne("Papu.Entities.Dish", "Dish")
                        .WithMany("KindsOf")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("Papu.Entities.Menu", b =>
                {
                    b.HasOne("Papu.Entities.Friday", "Friday")
                        .WithOne("Menu")
                        .HasForeignKey("Papu.Entities.Menu", "FridayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Monday", "Monday")
                        .WithOne("Menu")
                        .HasForeignKey("Papu.Entities.Menu", "MondayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Saturday", "Saturday")
                        .WithOne("Menu")
                        .HasForeignKey("Papu.Entities.Menu", "SaturdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Sunday", "Sunday")
                        .WithOne("Menu")
                        .HasForeignKey("Papu.Entities.Menu", "SundayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Thursday", "Thursday")
                        .WithOne("Menu")
                        .HasForeignKey("Papu.Entities.Menu", "ThursdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Tuesday", "Tuesday")
                        .WithOne("Menu")
                        .HasForeignKey("Papu.Entities.Menu", "TuesdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Wednesday", "Wednesday")
                        .WithOne("Menu")
                        .HasForeignKey("Papu.Entities.Menu", "WednesdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                    b.HasOne("Papu.Entities.Dish", "Dish")
                        .WithMany("Products")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Friday", "Friday")
                        .WithMany("Products")
                        .HasForeignKey("FridayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Monday", "Monday")
                        .WithMany("Products")
                        .HasForeignKey("MondayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Saturday", "Saturday")
                        .WithMany("Products")
                        .HasForeignKey("SaturdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Sunday", "Sunday")
                        .WithMany("Products")
                        .HasForeignKey("SundayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Thursday", "Thursday")
                        .WithMany("Products")
                        .HasForeignKey("ThursdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Tuesday", "Tuesday")
                        .WithMany("Products")
                        .HasForeignKey("TuesdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Papu.Entities.Wednesday", "Wednesday")
                        .WithMany("Products")
                        .HasForeignKey("WednesdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Friday");

                    b.Navigation("Monday");

                    b.Navigation("Saturday");

                    b.Navigation("Sunday");

                    b.Navigation("Thursday");

                    b.Navigation("Tuesday");

                    b.Navigation("Wednesday");
                });

            modelBuilder.Entity("Papu.Entities.Type", b =>
                {
                    b.HasOne("Papu.Entities.Dish", "Dish")
                        .WithMany("Types")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("Papu.Entities.Unit", b =>
                {
                    b.HasOne("Papu.Entities.Product", "Product")
                        .WithMany("Units")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Papu.Entities.Dish", b =>
                {
                    b.Navigation("KindsOf");

                    b.Navigation("Products");

                    b.Navigation("Types");
                });

            modelBuilder.Entity("Papu.Entities.Friday", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Menu");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Papu.Entities.Monday", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Menu");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Papu.Entities.Product", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("Papu.Entities.Saturday", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Menu");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Papu.Entities.Sunday", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Menu");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Papu.Entities.Thursday", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Menu");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Papu.Entities.Tuesday", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Menu");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Papu.Entities.Wednesday", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Menu");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
