using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mangatheque.Web.UI.Pages
{
    [Authorize(Roles = "Member")]
    public class ReadListModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
