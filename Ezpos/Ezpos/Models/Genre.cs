using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ezpos.Models
{
    public partial class Genre
    {
        public string Name { get; set; }

        public string GenreID { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}