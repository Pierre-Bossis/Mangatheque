using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mangatheque.Web.UI.Pages
{
    public class MangaDetailModel : PageModel
    {
        #region Fields
        private readonly IMangaRepository repository;
        #endregion
        #region Constructors
        public MangaDetailModel(IMangaRepository repository)
        {
            this.repository = repository;
        }
        #endregion
        #region Public Methods
        public IActionResult OnGet()
        {
            IActionResult result = this.Page();

            try
            {
                this.manga = this.repository.GetOne(this.Id);
            }
            catch (Exception)
            {

                result = this.NotFound();
            }
            return result;
        }
        #endregion
        #region Properties
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Manga? manga { get; set; }
        #endregion
    }
}
