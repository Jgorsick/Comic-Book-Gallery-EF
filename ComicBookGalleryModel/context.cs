using ComicBookGalleryModel.Models;
using System.Data.Entity;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
            public Context()

        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());


        }
        //public Context() : base("ComicBookGallery")
        //   {

        //    }

        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}
