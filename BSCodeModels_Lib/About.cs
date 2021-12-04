using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BSCodeModels_Lib
{
    [Table("tbl_about")]
    public class About
    {
        [Key]
        public Guid ID { get; set; } 

        [Required]
        [StringLength(100, ErrorMessage = "Title too long!")]
        public string Title { get; set; }

        [StringLength(250,MinimumLength =50, ErrorMessage = "Short Description must be between 50 and 20 characters!")]
        public string ShortDescription { get; set; }

        [StringLength(1000, MinimumLength = 50, ErrorMessage = "Long Description must be between 50 and 20 characters!")]
        public string LongDescription { get; set; }

        [StringLength(2000, ErrorMessage = "About Points too long!")]
        public string AboutPoints { get; set; }

        [StringLength(200, ErrorMessage = "Last Thought too long!")]
        public string LastThought { get; set; }

        [StringLength(200, ErrorMessage = "Image Name too long!")]
        public string ImageName { get; set; }
    }
}
