using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel
{
    public class Artist
    {
        public Artist()
        {
            ComicBooks = new List<ComicBookArtist>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ComicBookArtist> ComicBooks { get; set; }
    }
}
