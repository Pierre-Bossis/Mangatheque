using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mangatheque.Web.UI.Pages
{
    [Authorize(Roles = "Administrator")]
    public class EditMangaModel : PageModel
    {
        #region Fields
        private readonly IMangaRepository repository;
        #endregion

        #region Constructors
        public EditMangaModel(IMangaRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Public Methods
        public void OnGet(int id)
        {
           manga = this.repository.GetOne(id);
        }

        public IActionResult OnPost()
        {
            IActionResult result = this.Page();
            if(!ModelState.IsValid)
            {
                return result;
            }
            this.repository.Update(manga);

            TempData["AlertMessage"] = "Le Manga à bien été mis à jour.";
            result = this.RedirectToPage("/AllT1MangaList");
            return result;
        }
        #endregion

        #region Properties

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty]
        public Manga manga { get; set; }
        #endregion
    }
}
