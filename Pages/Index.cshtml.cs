using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mycoreproject.Pages
{
    public class ChartData
    {
        public string Browser { get; set; }
        public double Users { get; set; }
    }
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
