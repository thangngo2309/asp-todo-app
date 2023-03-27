﻿// <auto-generated />
using System;
using API.ToDo.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace API.ToDo.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    partial class ToDoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.SqlServer)
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ABP.ToDo.Entities.ToDoItem", b =>
            {
                b.Property<Guid>("Id")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasMaxLength(40)
                    .HasColumnType("nvarchar(40)")
                    .HasColumnName("ConcurrencyStamp");

                b.Property<DateTime>("CreationTime")
                    .HasColumnType("datetime2")
                    .HasColumnName("CreationTime");

                b.Property<Guid?>("CreatorId")
                    .HasColumnType("uniqueidentifier")
                    .HasColumnName("CreatorId");

                b.Property<double>("DayContrain")
                    .HasColumnType("float");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("DueDate")
                    .HasColumnType("datetime2");

                b.Property<string>("ExtraProperties")
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("ExtraProperties");

                b.Property<DateTime?>("LastModificationTime")
                    .HasColumnType("datetime2")
                    .HasColumnName("LastModificationTime");

                b.Property<Guid?>("LastModifierId")
                    .HasColumnType("uniqueidentifier")
                    .HasColumnName("LastModifierId");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.HasKey("Id");

                b.ToTable("ToDoItem", (string)null);
            });
#pragma warning restore 612, 618
        }
    }
}
