// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1C_accounting.DataBase;

namespace _1C_accounting.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IngridientProduct", b =>
                {
                    b.Property<Guid>("Ingridientsid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Productsid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Ingridientsid", "Productsid");

                    b.HasIndex("Productsid");

                    b.ToTable("IngridientProduct");
                });

            modelBuilder.Entity("_1C_accounting.Models.Ingridient", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<decimal>("Zero_price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Ingridients");
                });

            modelBuilder.Entity("_1C_accounting.Models.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<decimal>("Zero_price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("IngridientProduct", b =>
                {
                    b.HasOne("_1C_accounting.Models.Ingridient", null)
                        .WithMany()
                        .HasForeignKey("Ingridientsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1C_accounting.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("Productsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
