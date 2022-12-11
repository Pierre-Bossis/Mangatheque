using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mangatheque.Web.UI.Pages
{
    public class AddOneModel : PageModel
    {
        #region Fields
        private readonly IMangaRepository repository;
        #endregion
        #region Public Methods
        public AddOneModel(IMangaRepository repository)
        {
            this.repository = repository;

        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            IActionResult result = this.Page();

            if (this.ModelState.IsValid)
            {
                this.repository.Save(manga);

                this.ModelState.Clear();

                result = this.RedirectToPage("/AddOne");
            }
            return result;
        }
        #endregion
        #region Properties
        [BindProperty]
        public Manga manga { get; set; }
        #endregion
    }
}
