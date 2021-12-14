using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BSCodeModels_Lib
{
    [Table("tbl_event")]
    public class Event
    {
        [Key]
        public Guid ID { get; set; }

        [DisplayName("Title")]
        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Title too long!")]
        public string Title { get; set; }

        [DisplayName("Time of event")]
        public DateTime Time { get; set; }

        [DisplayName("Disciption")]
        [StringLength(500, ErrorMessage = "Disciption too long!")]
        public string Disciption { get; set; }

        [DisplayName("Image Name")]
        public string ImageName { get; set; }
    }
}
