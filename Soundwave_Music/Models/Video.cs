using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Soundwave_Music.Models
{
    [Table("Video")]
    public partial class Video
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Video()
        {
            Video_Comment = new HashSet<Video_Comment>();
            Video_Love_React = new HashSet<Video_Love_React>();
        }

        //View id
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Video ID")]
        public int Video_id { get; set; }

        //Video image
        [Required(ErrorMessage = "You have to upload an image for music video.")]
        [StringLength(500)]
        public string Image { get; set; }

        //Video name
        [Required]
        [StringLength(100)]
        [Display(Name = "Video Name")]
        public string Video_name { get; set; }

        //View Count
        [Display(Name = "View")]
        public int View_count { get; set; }

        //Release name
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Release_date { get; set; }

        //Music lyric
        public string Lyric { get; set; }

        //Create by
        [StringLength(100)]
        public string Create_by { get; set; }

        //Upload Video
        [StringLength(500)]
        [Display(Name = "Upload Video")]
        public string Video_File_Upload { get; set; }

        public int Singer_id { get; set; }

        public int Composer_id { get; set; }

        public int Genre_id { get; set; }

        public int Supplier_id { get; set; }

        public int Area_id { get; set; }

        public virtual Area Area { get; set; }

        public virtual Composer Composer { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Singer Singer { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video_Comment> Video_Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video_Love_React> Video_Love_React { get; set; }
    }
}
