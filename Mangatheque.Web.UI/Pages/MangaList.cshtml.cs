using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mangatheque.Web.UI.Pages
{
    public class MangaListModel : PageModel
    {
        #region Fields
        private readonly IMangaRepository repository;
        #endregion
        #region Constructors
        public MangaListModel(IMangaRepository repository)
        {
            this.repository = repository;
        }
        #endregion
        #region Public Methods
        public void OnGet()
        {
            SetListMangas();
        }
        #endregion
        #region Private Methods
        private void SetListMangas()
        {
            Mangas = repository.GetAll();
        }
        #endregion
        #region Properties
        public List<Manga> Mangas { get; set; } = new List<Manga>();
        #endregion
    }
}
