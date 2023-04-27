using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_6.DB_Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Duration { get; set; }

        public DateTime ReleasedDate { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public List<SongToArtist> SongToArtist { get; set; }
    }
}
