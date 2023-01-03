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
        private readonly MangaDbContext context;
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
            this.context?.Mangas.Add(manga);

            var entry = this.context?.Entry(manga.stock);
            entry.State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;

            this.context?.SaveChanges();
        }

        public List<Manga> GetList(string nom)
        {
            var Query = from item in this.context?.Mangas.Include(item => item.stock).Where(c => c.Nom == nom)
                        select item;

            return Query.ToList();
        }

        public List<Manga> GetListT1()
        {
            var Query = from item in this.context?.Mangas.Include(item => item.stock).Where(item => item.Numero == 1)
                        select item;

            return Query.ToList();
        }

        public Manga? GetOne(int Id)
        {
            return this.context?.Mangas.Include(item=>item.stock)
                    .First(item => item.Id == Id);
        }

        public void Delete(int Id)
        {
            this.context.Mangas.Where(x => x.Id == Id).ExecuteDelete();
            this.context?.SaveChanges();
            /*
            var entry = this.context?.Entry(Id);
            entry.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            this.context?.SaveChanges();*/

        }

        public void Update(Manga manga)
        {
            var entity = context.Mangas.Find(manga.Id);

            entity.Nom = manga.Nom;
            entity.Auteur = manga.Auteur;
            entity.Numero = manga.Numero;
            entity.DatePublication = manga.DatePublication;
            entity.Genre = manga.Genre;
            entity.stock = manga.stock;
            
            this.context?.Mangas.Update(entity);
            this.context?.SaveChanges();
        }
        #endregion
    }
}
