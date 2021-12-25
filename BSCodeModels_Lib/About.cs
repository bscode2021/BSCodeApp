using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BSCodeModels_Lib
{
    [Table("tbl_about")]
    public class About
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [Display(Name = "Title:", Prompt = "Enter title")]
        [StringLength(100, ErrorMessage = "Title too long!")]
        public string Title { get; set; }

        [Display(Name = "Short description:", Prompt = "Enter a short description")]
        [StringLength(250, MinimumLength = 50, ErrorMessage = "Short Description must be between 50 and 20 characters!")]
        public string ShortDescription { get; set; }

        [Display(Name = "Long description:", Prompt = "Enter a long description")]
        [StringLength(1000, MinimumLength = 50, ErrorMessage = "Long Description must be between 50 and 20 characters!")]
        public string LongDescription { get; set; }

        [Display(Name = "About points:", Prompt = "Separate the points made with ';' so they will be shown as different buletpoints")]
        [StringLength(2000, ErrorMessage = "About Points too long!")]
        public string AboutPoints { get; set; }

        [Display(Name = "Last thought:", Prompt = "Enter last thought")]
        [StringLength(200, ErrorMessage = "Last Thought too long!")]
        public string LastThought { get; set; }

        [StringLength(200, ErrorMessage = "Image Name too long!")]
        [Display(Name = "Upload image:")]
        public string ImageName { get; set; }
    }
}
