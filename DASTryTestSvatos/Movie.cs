using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASTryTestSvatos
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Revenue { get; set; }
        public int MediaTypeId { get; set; }
    }
}
