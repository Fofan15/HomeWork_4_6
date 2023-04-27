using Microsoft.EntityFrameworkCore;

namespace CodeHomeWork_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                //1
                var request1 = context.Songs
                    .Where(p => p.GenreId != null && p.SongToArtist.Any(s => s.Artist.DateOfDeath == null))
                    .Select(s => new
                    {
                        SongTitle = s.Title,
                        ArtistName = s.SongToArtist.FirstOrDefault().Artist.Name,
                        GenreTitle = s.Genre.Title
                    });

                Console.WriteLine("Display the name of the song, the name of the artist, the name of the genre of the song. Display only songs that have a genre and that are written by an existing artist\n");
                Console.WriteLine(request1.ToQueryString());

                //2
                var request2 = context.Songs
                    .Where(p => p.GenreId != null)
                    .GroupBy(p => p.GenreId)
                    .Select(p => new
                    {
                        GenreId = p.Key,
                        Count = p.Count()
                    });

                Console.WriteLine();
                Console.WriteLine("Display the number of songs in each genre\n");
                Console.WriteLine(request2.ToQueryString());

                //3
                var request3 = context.Songs
                    .Where(s => s.ReleasedDate < context.Artists.Min(s => s.DateOfBirth))
                    .Select(s => new
                    {
                        SongTitle = s.Title,
                        ReleasedDate = s.ReleasedDate
                    });

                Console.WriteLine();
                Console.WriteLine("Display songs that were written (ReleasedDate) before the birth of the youngest performer.\n");
                Console.WriteLine(request3.ToQueryString());
            }
        }
    }
}