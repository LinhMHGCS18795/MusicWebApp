namespace Soundwave_Music.Models.AddColumnArea
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Album_Comment = new HashSet<Album_Comment>();
            Album_Love_React = new HashSet<Album_Love_React>();
            Like_Album_Comment = new HashSet<Like_Album_Comment>();
            Like_News_Comment = new HashSet<Like_News_Comment>();
            Like_Reply_News_Comment = new HashSet<Like_Reply_News_Comment>();
            Like_Song_Comment = new HashSet<Like_Song_Comment>();
            Like_Video_Comment = new HashSet<Like_Video_Comment>();
            News = new HashSet<News>();
            News_Comment = new HashSet<News_Comment>();
            Orders = new HashSet<Order>();
            Playlists = new HashSet<Playlist>();
            Reply_News_Comment = new HashSet<Reply_News_Comment>();
            Song_Comment = new HashSet<Song_Comment>();
            Song_Love_React = new HashSet<Song_Love_React>();
            Video_Comment = new HashSet<Video_Comment>();
            Video_Love_React = new HashSet<Video_Love_React>();
        }

        [Key]
        public int User_id { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Avatar { get; set; }

        [Required]
        [StringLength(100)]
        public string Full_name { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone_number { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        public DateTime Date_of_birth { get; set; }

        public DateTime Create_date { get; set; }

        public DateTime Update_date { get; set; }

        [StringLength(100)]
        public string Verification_code { get; set; }

        [StringLength(1)]
        public string User_Status { get; set; }

        public DateTime Expired { get; set; }

        public int? Role_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album_Comment> Album_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album_Love_React> Album_Love_React { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like_Album_Comment> Like_Album_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like_News_Comment> Like_News_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like_Reply_News_Comment> Like_Reply_News_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like_Song_Comment> Like_Song_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like_Video_Comment> Like_Video_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News_Comment> News_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Playlist> Playlists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reply_News_Comment> Reply_News_Comment { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song_Comment> Song_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song_Love_React> Song_Love_React { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video_Comment> Video_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video_Love_React> Video_Love_React { get; set; }
    }
}
