using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Soundwave_Music.Models
{   
    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Songs = new HashSet<Song>();
            Videos = new HashSet<Video>();
        }

        //Supplier ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Supplier ID")]
        public int Supplier_id { get; set; }

        //Supplier Name
        [Required(ErrorMessage = "Please input supplier name")]
        [StringLength(100)]
        [Display(Name = "Supplier Name")]
        public string Supplier_name { get; set; }

        //Image
        [Required(ErrorMessage = "You have to upload an image for supplier.")]
        [StringLength(500)]
        public string Image { get; set; }

        //Create date
        [Display(Name = "Create Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Create_date { get; set; }

        //Create by
        [Display(Name = "Create By")]
        [StringLength(100)]
        public string Create_by { get; set; }

        //Supplier status
        [StringLength(1)]
        public string Supplier_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song> Songs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Videos { get; set; }
    }
}
