﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using todolistgql;

#nullable disable

namespace TodoListGQL.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220614205950_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("todolistgql.ItemData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Done")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ItemListId")
                        .HasColumnType("int");

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ItemListId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("todolistgql.ItemList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("List");
                });

            modelBuilder.Entity("todolistgql.ItemData", b =>
                {
                    b.HasOne("todolistgql.ItemList", "ItemList")
                        .WithMany("ItemData")
                        .HasForeignKey("ItemListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemList");
                });

            modelBuilder.Entity("todolistgql.ItemList", b =>
                {
                    b.Navigation("ItemData");
                });
#pragma warning restore 612, 618
        }
    }
}
