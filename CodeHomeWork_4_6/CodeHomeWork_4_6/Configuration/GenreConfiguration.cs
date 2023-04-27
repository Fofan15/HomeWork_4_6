using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeHomeWork_4_6.DB_Models;

namespace CodeHomeWork_4_6.Configuration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
              .ToTable("Genre")
              .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("GenreId");

            builder
                .Property(p => p.Id)
                .IsRequired();

            builder
                .Property(p => p.Title)
                .IsRequired();

            builder
               .HasData(
               new Genre
               {
                   Id = 1,
                   Title = "Example 1.1"

               },

               new Genre
               {
                   Id = 2,
                   Title = "Example 2.1"
               },

               new Genre
               {
                   Id = 3,
                   Title = "Example 3.1"
               },

               new Genre
               {
                   Id = 4,
                   Title = "Example 4.1"
               },

               new Genre
               {
                   Id = 5,
                   Title = "Example 5.1"
               }
               );
        }
    }
}
