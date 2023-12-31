﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoListApp.Infrastructure.Data.Contexts;

#nullable disable

namespace ToDoListApp.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20230904155949_initial2")]
    partial class initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ToDoListApp.Domain.Models.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_completed");

                    b.Property<Guid>("ToDoListId")
                        .HasColumnType("char(36)")
                        .HasColumnName("todo_list_id");

                    b.HasKey("Id");

                    b.HasIndex("ToDoListId");

                    b.ToTable("task", (string)null);
                });

            modelBuilder.Entity("ToDoListApp.Domain.Models.ToDoList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("todo-list", (string)null);
                });

            modelBuilder.Entity("ToDoListApp.Domain.Models.Task", b =>
                {
                    b.HasOne("ToDoListApp.Domain.Models.ToDoList", "ToDoList")
                        .WithMany("Tasks")
                        .HasForeignKey("ToDoListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ToDoList");
                });

            modelBuilder.Entity("ToDoListApp.Domain.Models.ToDoList", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
