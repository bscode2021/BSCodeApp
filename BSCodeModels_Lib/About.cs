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
        [Display(Name = "Title:")]
        [StringLength(100, ErrorMessage = "Title too long!")]
        public string Title { get; set; }

        [Display(Name = "Short description:")]
        [StringLength(250,MinimumLength =50, ErrorMessage = "Short Description must be between 50 and 20 characters!")]
        public string ShortDescription { get; set; }

        [Display(Name = "Long description:")]
        [StringLength(1000, MinimumLength = 50, ErrorMessage = "Long Description must be between 50 and 20 characters!")]
        public string LongDescription { get; set; }

        [Display(Name = "About points:")]
        [StringLength(2000, ErrorMessage = "About Points too long!")]
        public string AboutPoints { get; set; }

        [Display(Name = "Last thought:")]
        [StringLength(200, ErrorMessage = "Last Thought too long!")]
        public string LastThought { get; set; }

        [Display(Name = "Upload image:")]
        [StringLength(200, ErrorMessage = "Image Name too long!")]
        public string ImageName { get; set; }
    }
}
