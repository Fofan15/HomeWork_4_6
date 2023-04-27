using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_6.DB_Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Song> Song { get; set; }
    }
}
