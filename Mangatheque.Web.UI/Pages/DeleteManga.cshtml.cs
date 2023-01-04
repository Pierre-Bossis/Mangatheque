using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Mangatheque.Web.UI.Pages
{
    [Authorize(Roles = "Administrator")]
    public class DeleteMangaModel : PageModel
    {
        #region Fields
        private readonly IMangaRepository repository;
        #endregion

        #region Constructors
        public DeleteMangaModel(IMangaRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Public Methods

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (this.ModelState.IsValid)
            {
                this.repository.Delete(Id);
                TempData["AlertMessage"] = "Le Manga à bien été supprimé.";
            }
            return  this.RedirectToPage("/AllT1MangaList");
        }
        #endregion

        #region Properties
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        #endregion
    }
    
}
