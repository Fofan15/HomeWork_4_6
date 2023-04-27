using CodeHomeWork_4_6.DB_Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_6.Configuration
{
    internal class SongToArtistConfiguration : IEntityTypeConfiguration<SongToArtist>
    {
        public void Configure(EntityTypeBuilder<SongToArtist> builder)
        {
            builder
              .ToTable("SongToArtist")
              .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("SongToArtistId");

            builder
               .HasData(
               new SongToArtist
               {
                   Id = 1,
                   ArtistId = 1,
                   SongId = 1
               },

               new SongToArtist
               {
                   Id = 2,
                   ArtistId = 2,
                   SongId = 2
               },

               new SongToArtist
               {
                   Id = 3,
                   ArtistId = 3,
                   SongId = 3
               },

               new SongToArtist
               {
                   Id = 4,
                   ArtistId = 4,
                   SongId = 4
               },

               new SongToArtist
               {
                   Id = 5,
                   ArtistId = 5,
                   SongId = 5
               }
               );
        }
    }
}
