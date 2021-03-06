﻿using ComicBookGalleryModel.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<ComicBook>()
                .Property(cb => cb.AverageRating)
                .HasPrecision(5, 2);
        }
        public DbSet<ComicBook> ComicBooks { get; set; }

    }
}
