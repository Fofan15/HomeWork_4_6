using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CodeHomeWork_4_6.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_6.Configuration
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder
               .ToTable("Artist")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("ArtistId");

            builder
                .Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(e => e.DateOfBirth)
                .IsRequired();

            builder
                .HasData(
                new Artist
                {
                    Id = 1,
                    Name = "David",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    DateOfDeath = new DateTime(2023, 1, 1),
                    Phone = "11111111",
                    Email = "example1@gmail.com",
                    InstagramUrl = "instagram1.com"
                },

                new Artist
                {
                    Id = 2,
                    Name = "Sveta",
                    DateOfBirth = new DateTime(2000, 2, 2),
                    Phone = "22222222",
                    Email = "example2@gmail.com",
                    InstagramUrl = "instagram2.com"
                },

                new Artist
                {
                    Id = 3,
                    Name = "Roma",
                    DateOfBirth = new DateTime(2000, 3, 3),
                    DateOfDeath = new DateTime(2023, 3, 3),
                    Phone = "33333333",
                    Email = "example3@gmail.com",
                    InstagramUrl = "instagram3.com"
                },

                new Artist
                {
                    Id = 4,
                    Name = "Tanya",
                    DateOfBirth = new DateTime(2000, 4, 4),
                    Phone = "44444444",
                    Email = "example4@gmail.com",
                    InstagramUrl = "instagram4.com"
                },

                new Artist
                {
                    Id = 5,
                    Name = "Vanya",
                    DateOfBirth = new DateTime(2000, 5, 5),
                    DateOfDeath = new DateTime(2023, 5, 5),
                    Phone = "55555555",
                    Email = "example5@gmail.com",
                    InstagramUrl = "instagram5.com"
                }
                );
        }
    }
}
