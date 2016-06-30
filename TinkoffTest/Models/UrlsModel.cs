namespace TinkoffTest
{
    using System.Data.Entity;

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
