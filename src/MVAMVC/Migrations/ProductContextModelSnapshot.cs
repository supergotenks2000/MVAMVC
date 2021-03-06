using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MVAMVC.Models;

namespace MVAMVC.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVAMVC.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:ColumnName", "CategoryID");

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.HasKey("CategoryId");
                });

            modelBuilder.Entity("MVAMVC.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:ColumnName", "ProductID");

                    b.Property<int?>("CategoryId")
                        .HasAnnotation("Relational:ColumnName", "CategoryID");

                    b.Property<decimal?>("CurrentPrice");

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<decimal?>("MSRP");

                    b.HasKey("ProductId");
                });

            modelBuilder.Entity("MVAMVC.Models.Product", b =>
                {
                    b.HasOne("MVAMVC.Models.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
        }
    }
}
