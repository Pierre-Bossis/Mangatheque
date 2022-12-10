using Mangatheque.Core.Interfaces.Infrastructures;
using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Application.Repositories
{
    public class MangaRepository : IMangaRepository

    {
        #region Fields
        private readonly IMangaDataLayer DataLayer;
        #endregion
        #region Constructors
        public MangaRepository(IMangaDataLayer Datalayer)
        {
            this.DataLayer = Datalayer;
        }
        #endregion
        #region public methods
        public List<Manga> GetAll()
        {
            List<Manga> list = this.DataLayer.GetList();

            return list;
        }

        public Manga GetOne(int Id)
        {
            Manga manga = this.DataLayer.GetOne(Id);

            if(manga == null)
            {
                throw new ArgumentException("Id");
            }
            return manga;
        }

        public void Save(Manga manga)
        {
            this.DataLayer.AddOne(manga);
        }
        #endregion
    }
}
