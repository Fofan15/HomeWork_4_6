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
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder
               .ToTable("Song")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("SongId");

            builder
                .Property(p => p.Id)
                .IsRequired();

            builder
                .Property(p => p.Title)
                .IsRequired();

            builder
                .Property(p => p.Duration)
                .IsRequired();

            builder
                .Property(p => p.ReleasedDate)
                .IsRequired();

            builder
                .HasOne(p => p.Genre)
                .WithMany(p => p.Song)
                .HasForeignKey(p => p.GenreId)
                .IsRequired();


            builder
               .HasData(
               new Song
               {
                   Id = 1,
                   Title = "Example 1",
                   Duration = "1:11",
                   ReleasedDate = new DateTime(2010, 1, 1),
                   GenreId = 1
               },

               new Song
               {
                   Id = 2,
                   Title = "Example 2",
                   Duration = "2:22",
                   ReleasedDate = new DateTime(2010, 2, 2),
                   GenreId = 2
               },

               new Song
               {
                   Id = 3,
                   Title = "Example 3",
                   Duration = "3:33",
                   ReleasedDate = new DateTime(2010, 3, 3),
                   GenreId = 3
               },

               new Song
               {
                   Id = 4,
                   Title = "Example 4",
                   Duration = "4:44",
                   ReleasedDate = new DateTime(2010, 4, 4),
                   GenreId = 4
               },

               new Song
               {
                   Id = 5,
                   Title = "Example 5",
                   Duration = "5:55",
                   ReleasedDate = new DateTime(2010, 5, 5),
                   GenreId = 5
               }
               );
        }
    }
}
