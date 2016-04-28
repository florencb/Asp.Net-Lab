using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using asp.Models;

namespace asp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("asp.Models.Trip", b =>
                {
                    b.Property<string>("ID");

                    b.Property<string>("CreatedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Stops");

                    b.Property<string>("UserName");

                    b.HasKey("ID");
                });
        }
    }
}
