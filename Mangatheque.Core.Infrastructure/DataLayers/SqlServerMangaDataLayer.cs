using Mangatheque.Core.Infrastructure.Databases;
using Mangatheque.Core.Interfaces.Infrastructures;
using Mangatheque.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Infrastructure.DataLayers
{
    public class SqlServerMangaDataLayer : IMangaDataLayer
    {
        #region Fields
        private readonly MangaDbContext? context = null;
        #endregion
        #region Constructors
        public SqlServerMangaDataLayer(MangaDbContext context)
        {
            this.context = context;
        }
        #endregion
        #region Public Methods
        public void AddOne(Manga manga)
        {
            throw new NotImplementedException();
        }

        public List<Manga> GetList()
        {
            var Query = from item in this.context?.Mangas.Include(item=>item.stock)
                                            select item;

            return Query.ToList();
        }

        public Manga? GetOne(int Id)
        {
            return this.context?.Mangas.Include(item=>item.stock)
                    .First(item => item.Id == Id);
        }
        #endregion
    }
}
