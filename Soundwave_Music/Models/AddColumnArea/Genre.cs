namespace Soundwave_Music.Models.AddColumnArea
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Genre")]
    public partial class Genre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genre()
        {
            Albums = new HashSet<Album>();
            Songs = new HashSet<Song>();
            Videos = new HashSet<Video>();
        }

        [Key]
        public int Genre_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre_name { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        public DateTime Create_date { get; set; }

        [StringLength(100)]
        public string Create_by { get; set; }

        [StringLength(1)]
        public string Genre_status { get; set; }

        public int Area_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Albums { get; set; }

        public virtual Area Area { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song> Songs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Videos { get; set; }
    }
}
