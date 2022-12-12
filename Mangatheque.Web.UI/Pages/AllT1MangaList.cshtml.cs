using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mangatheque.Web.UI.Pages
{
    public class AllT1MangaListModel : PageModel
    {
        #region Fields
        private readonly IMangaRepository repository;
        #endregion

        #region Constructors
        public AllT1MangaListModel(IMangaRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Public Methods
        public void OnGet()
        {
            SetListMangasT1();
        }
        #endregion

        #region Private Methods
        private void SetListMangasT1()
        {
            this.Mangas = this.repository.GetAllT1();
        }
        #endregion

        #region Properties
        public List<Manga> Mangas {get;set;} = new List<Manga>();
        #endregion
    }
}
