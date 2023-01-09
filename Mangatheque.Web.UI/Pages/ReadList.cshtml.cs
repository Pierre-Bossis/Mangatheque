using Mangatheque.Core.Infrastructure.Databases;
using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Mangatheque.Web.UI.Pages
{
    [Authorize(Roles = "Member")]
    public class ReadListModel : PageModel
    {
        #region Fields
        private readonly IMangaRepository repository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        #endregion

        #region Constructors
        public ReadListModel(IMangaRepository repository, IHttpContextAccessor httpContextAccessor)
        {
            this.repository = repository;
            this._httpContextAccessor = httpContextAccessor;
        }
        #endregion
        #region Public Methods
        public void OnGet()
        {
            var id = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            this.Mangas = this.repository.GetReadList(id);
        
        }

        public IActionResult OnGetDeleteReadList()
        {
            var result = this.RedirectToPage("/index");

            this.repository?.DeleteFromReadList(monId, _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

            TempData["AlertMessage"] = "Le Manga à bien été supprimé de votre liste.";


            return result;
        }
        #endregion

        #region Properties
        [BindProperty]
        public List<Manga> Mangas { get; set; }

        [BindProperty(SupportsGet =true)]
        public int monId { get; set; }
        #endregion
    }
}
