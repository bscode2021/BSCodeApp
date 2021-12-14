using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BSCodeModels_Lib.Support.SuportEnums;

namespace BSCodeModels_Lib
{
    [Table("tbl_trainer")]
    public class Trainer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        [Display(Name = "Enter name:", Prompt = "Enter full name ")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "The name shoud be between 10 and 150 characters!")]
        public string Name { get; set; }

        [Display(Name = "Enter description:", Prompt = "Description maximum 500 characters")]
        [StringLength(500, ErrorMessage = "The description should't be over 500 characters!")]
        public string Description { get; set; }

        public Specialty Specialty { get; set; }

        [Display(Name = "Upload image")]
        public string Image { get; set; }

        [Display(Name = "Enter TwiterURL:", Prompt = "Must be url from twiter")]
        [RegularExpression(@"/(^|[^@\w])@(\w{1,15})\b/", ErrorMessage = "This is no a twiter link.")]
        public string TwiterURL { get; set; }

        [Display(Name = "Enter FacebookURL:", Prompt = "Must be url from Facebook")]
        [RegularExpression(@"(?:(?:http|https):\/\/)?(?:www.)?facebook.com\/(?:(?:\w)*#!\/)?(?:pages\/)?(?:[?\w\-]*\/)?(?:profile.php\?id=(?=\d.*))?([\w\-]*)?", ErrorMessage = "This link is not from facebook.")]
        public string FacebookURL { get; set; }

        [Display(Name = "Enter InstagramURl:", Prompt = "Must be url from Instagram")]
        [RegularExpression(@"(?:(?:http|https):\/\/)?(?:www.)?(?:instagram.com|instagr.am|instagr.com)\/(\w+)", ErrorMessage = "This in not a instagram link.")]
        public string InstagramURl { get; set; }

        [Display(Name = "Enter LinkedinURL:", Prompt = "Must be url from Linkedin")]
        [RegularExpression(@"^https:\\/\\/[a-z]{2,3}\\.linkedin\\.com\\/.*$", ErrorMessage = "This is not a linkedin link.")]
        public string LinkedinURL { get; set; }

    }
}
