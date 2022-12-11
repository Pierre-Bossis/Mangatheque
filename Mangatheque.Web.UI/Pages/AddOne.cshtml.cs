using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

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
                manga.Couverture = ConvertToBytes(myFile);

                this.repository.Save(manga);
                

                this.ModelState.Clear();

                result = this.RedirectToPage("/MangaList");
            }
            return result;
        }
        #endregion

        #region Private Methods
        private byte[] ConvertToBytes(IFormFile image)
        {
            byte[] CoverImageBytes = null;
            BinaryReader reader = new BinaryReader(image.OpenReadStream());
            CoverImageBytes = reader.ReadBytes((int)image.Length);
            return CoverImageBytes;
        }
        #endregion

        #region Properties
        [BindProperty]
        public Manga manga { get; set; }

        [BindProperty]
        public IFormFile myFile { get; set; }
        #endregion

    }
}
