using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using asp.Models;

namespace asp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20160503174129_phase2")]
    partial class phase2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("asp.Models.Stop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<int?>("TripID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("asp.Models.Trip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("UserName");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("asp.Models.Stop", b =>
                {
                    b.HasOne("asp.Models.Trip")
                        .WithMany()
                        .HasForeignKey("TripID");
                });
        }
    }
}
