using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Survey> Surveys { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var stringListConverter = new ValueConverter<List<string>, string>(
        v => string.Join(";", v),
        v => v.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList());

        var stringListComparer = new ValueComparer<List<string>>(
            (c1, c2) => c1.SequenceEqual(c2),
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList());


        modelBuilder.Entity<Survey>()
            .Property(e => e.FavoriteFoods)
            .HasConversion(stringListConverter)
            .Metadata.SetValueComparer(stringListComparer);

    }
}
