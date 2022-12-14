// <auto-generated />
using System;
using GraphQlServer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GraphQlServer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220831055412_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GraphQlServer.Model.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("IsBlock")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("GraphQlServer.Model.SubTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TaskListId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TaskListId");

                    b.ToTable("SubTasks");
                });

            modelBuilder.Entity("GraphQlServer.Model.TaskList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("TaskLists");
                });

            modelBuilder.Entity("GraphQlServer.Model.SubTask", b =>
                {
                    b.HasOne("GraphQlServer.Model.TaskList", null)
                        .WithMany("Tasks")
                        .HasForeignKey("TaskListId");
                });

            modelBuilder.Entity("GraphQlServer.Model.TaskList", b =>
                {
                    b.HasOne("GraphQlServer.Model.Account", null)
                        .WithMany("TaskList")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("GraphQlServer.Model.Account", b =>
                {
                    b.Navigation("TaskList");
                });

            modelBuilder.Entity("GraphQlServer.Model.TaskList", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
