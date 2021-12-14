using BSCodeModels_Lib;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;

namespace BScodeWeb.Models
{
    public class AboutView
    {
        public About About { get; set; }

        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
