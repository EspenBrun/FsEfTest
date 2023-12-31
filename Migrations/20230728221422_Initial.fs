﻿// <auto-generated />
namespace FsEfTest.Migrations

open System
open FsEfTest
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Infrastructure
open Microsoft.EntityFrameworkCore.Metadata
open Microsoft.EntityFrameworkCore.Migrations
open Microsoft.EntityFrameworkCore.Storage.ValueConversion

[<DbContext(typeof<BloggingModel.BloggingContext>)>]
[<Migration("20230728221422_Initial")>]
type Initial() =
    inherit Migration()

    override this.Up(migrationBuilder:MigrationBuilder) =
        migrationBuilder.AlterDatabase(
            ).Annotation("MySql:CharSet", "utf8mb4") |> ignore

        migrationBuilder.CreateTable(
            name = "Blogs"
            ,columns = (fun table -> 
            {|
                Id =
                    table.Column<int>(
                        nullable = false
                        ,``type`` = "int"
                    ).Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                Url =
                    table.Column<string>(
                        nullable = false
                        ,``type`` = "longtext"
                    ).Annotation("MySql:CharSet", "utf8mb4")
            |})
            , constraints =
                (fun table -> 
                    table.PrimaryKey("PK_Blogs", (fun x -> (x.Id) :> obj)
                    ) |> ignore
                )
        ).Annotation("MySql:CharSet", "utf8mb4") |> ignore


    override this.Down(migrationBuilder:MigrationBuilder) =
        migrationBuilder.DropTable(
            name = "Blogs"
            ) |> ignore


    override this.BuildTargetModel(modelBuilder: ModelBuilder) =
        modelBuilder
            .HasAnnotation("ProductVersion", "6.0.13")
            .HasAnnotation("Relational:MaxIdentifierLength", 64) |> ignore

        modelBuilder.Entity("FsEfTest.BloggingModel+Blog", (fun b ->

            b.Property<int>("Id")
                .IsRequired(true)
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                |> ignore

            b.Property<string>("Url")
                .IsRequired(true)
                .HasColumnType("longtext")
                |> ignore

            b.HasKey("Id")
                |> ignore


            b.ToTable("Blogs") |> ignore

        )) |> ignore

