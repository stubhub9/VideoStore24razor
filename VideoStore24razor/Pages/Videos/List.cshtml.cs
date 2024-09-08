using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VideoStore24razor.Pages.Videos
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _config;
        public string PageTitle { get; set; }
        public ListModel(IConfiguration config)
        {
            _config = config;
        }
        public void OnGet()
        {
            PageTitle = _config["VideoListPageTitle"];
        }
    }
}
