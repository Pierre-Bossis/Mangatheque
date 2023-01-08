using Mangatheque.Core.Infrastructure.Databases;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mangatheque.Web.UI.Pages
{
    [Authorize(Roles = "Member")]
    public class ReadListModel : PageModel
    {
        #region Fields

        #endregion

        #region Constructors
        public ReadListModel()
        {

        }
        #endregion
        #region Public Methods
        public void OnGet()
        {

        }
        #endregion

        #region Properties

        #endregion
    }
}
