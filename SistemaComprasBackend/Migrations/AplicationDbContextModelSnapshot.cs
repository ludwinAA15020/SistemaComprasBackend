// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaComprasBackend;

#nullable disable

namespace SistemaComprasBackend.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaComprasBackend.Models.Producto", b =>
                {
                    b.Property<string>("id_producto")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("caracteristica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre_producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_producto");

                    b.ToTable("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
