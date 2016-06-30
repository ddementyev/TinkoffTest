namespace TinkoffTest
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UrlsData")]
    public partial class UrlsData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public string ShortUrl { get; set; }

        public string InitialUrl { get; set; }

        public DateTime? CreationDate { get; set; }

        public int? Clicks { get; set; }
    }
}
