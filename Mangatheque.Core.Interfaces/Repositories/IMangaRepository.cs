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
        /// Retourne la liste des mangas d'une readlist d'un utilisateur
        /// </summary>
        /// <returns></returns>
        List<Manga> GetReadList(string id);

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
        /// Ajoute ou mise à jour d'un manga dans la readlist d'un user
        /// </summary>
        /// <param name="manga"></param>
        void AddToReadList(int id, string idstring);

        /// <summary>
        /// Supprime un Manga
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        void Delete(int Id);

        /// <summary>
        /// supprime un manga de la readlist d'un user
        /// </summary>
        /// <param name="id"></param>
        void DeleteFromReadList(int id,  string idstring);

        /// <summary>
        /// Edite un Manga
        /// </summary>
        /// <param name="manga"></param>
        /// <returns></returns>
        void Update(Manga manga);
    }
}
