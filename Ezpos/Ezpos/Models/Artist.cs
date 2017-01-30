using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ezpos.Models
{
    public class Artist
    {

        public int ArtistID { get; set; }
        public string Name { get; set; }


        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }

    }
}