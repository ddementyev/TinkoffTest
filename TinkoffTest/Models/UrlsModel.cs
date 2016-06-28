namespace TinkoffTest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UrlsModel : DbContext
    {
        public UrlsModel()
            : base("name=UrlsDb")
        {
        }

        public virtual DbSet<UrlsData> UrlsData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UrlsData>()
                .Property(e => e.ShortUrl)
                .IsUnicode(false);

            modelBuilder.Entity<UrlsData>()
                .Property(e => e.InitialUrl)
                .IsUnicode(false);
        }
    }
}
