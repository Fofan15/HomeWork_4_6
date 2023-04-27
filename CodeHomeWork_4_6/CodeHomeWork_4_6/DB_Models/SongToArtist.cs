using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_6.DB_Models
{
    public class SongToArtist
    {
        public int Id { get; set; }

        public int SongId { get; set; }

        public Song Song { get; set; }

        public int ArtistId { get; set; }

        public Artist Artist { get; set; }
    }
}
