using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Mangatheque.Web.UI.Pages
{
    public class MangaListModel : PageModel
    {
        #region Fields
        private readonly IMangaRepository repository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        #endregion
        #region Constructors
        public MangaListModel(IMangaRepository repository, IHttpContextAccessor httpContextAccessor)
        {
            this.repository = repository;
            this._httpContextAccessor = httpContextAccessor;
        }
        #endregion
        #region Public Methods
        public IActionResult OnGet()
        {
            IActionResult result = this.Page();

            try
            {
                this.Mangas = this.repository.GetAll(nom);
            }
            catch (Exception)
            {

                result = this.NotFound();
            }
            return result;
        }

        public IActionResult OnGetAddToReadList()
        {
            var result = this.RedirectToPage("/index");

            this.repository.AddToReadList(monId2, _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

            TempData["AlertMessage"] = "Le Manga à bien été ajouté à votre liste.";
            return result;
        }
        #endregion
        #region Private Methods
        //private void SetListMangas()
        //{
        //    Mangas = repository.GetAll(nom);
        //}
        #endregion

        #region Properties
        public List<Manga> Mangas { get; set; } = new List<Manga>();

        [BindProperty(SupportsGet = true)]
        public string nom { get; set; }

        [BindProperty(SupportsGet =true)]
        public int monId2 { get; set; }
        #endregion
    }
}
