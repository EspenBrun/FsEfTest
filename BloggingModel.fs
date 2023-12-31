module FsEfTest.BloggingModel

open System.ComponentModel.DataAnnotations
open Microsoft.EntityFrameworkCore
open EntityFrameworkCore.FSharp.Extensions

[<CLIMutable>]
type Blog = {
    [<Key>] Id: int
    Url: string
    MaybeAuthor: string option
}

type BloggingContext() =  
    inherit DbContext()
    
    [<DefaultValue>] val mutable blogs : DbSet<Blog>
    member this.Blogs with get() = this.blogs and set v = this.blogs <- v

    override _.OnModelCreating builder =
        builder.RegisterOptionTypes() // enables option values for all entities

    override __.OnConfiguring(options: DbContextOptionsBuilder) : unit =
        let connectionString = "Server=localhost; Port=3306; Database=fseftestdb; Uid=root;"
        let serverVersion = ServerVersion.AutoDetect(connectionString)
        options.UseMySql(connectionString, serverVersion) |> ignore
