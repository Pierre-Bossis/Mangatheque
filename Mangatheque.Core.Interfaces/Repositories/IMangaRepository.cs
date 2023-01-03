using Mangatheque.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Interfaces.Repositories
{
    public interface IMangaRepository
    {
        List<Manga> GetAll(string nom);

        /// <summary>
        /// retourne la liste des manga Tome 1
        /// </summary>
        /// <returns></returns>
        List<Manga> GetAllT1();

        /// <summary>
        /// retourne un Manga par son Id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Manga GetOne(int Id);

        /// <summary>
        /// Ajout ou mise à jour d'un Manga.
        /// </summary>
        /// <param name="manga"></param>
        void Save(Manga manga);

        /// <summary>
        /// Supprime un Manga
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        void Delete(int Id);

        /// <summary>
        /// Edite un Manga
        /// </summary>
        /// <param name="manga"></param>
        /// <returns></returns>
        void Update(Manga manga);
    }
}
