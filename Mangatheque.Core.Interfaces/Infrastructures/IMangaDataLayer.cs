using Mangatheque.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Interfaces.Infrastructures
{
    /// <summary>
    /// isole l'accès a la base de donnée.
    /// </summary>
    public interface IMangaDataLayer
    {
        /// <summary>
        /// Retourne la liste complète
        /// </summary>
        /// <returns></returns>
        List<Manga> GetList(string nom);
        
        /// <summary>
        /// Retourne la liste des tome 1
        /// </summary>
        /// <returns></returns>
        List<Manga> GetListT1();

        /// <summary>
        /// appelle la base de donnée pour la liste de manga d'une readlist d'un utilisateur
        /// </summary>
        /// <returns></returns>
        List<Manga> GetReadList(string id);

        /// <summary>
        /// Appelle la base pour retourner un Manga.
        /// </summary>
        /// <returns></returns>
        Manga GetOne(int Id);

        /// <summary>
        /// appelle la base pour l'ajout d'un nouveau Manga en base de donnée.
        /// </summary>
        void AddOne(Manga manga);

        /// <summary>
        /// appelle la base pour Ajouter ou mise à jour d'un manga dans la readlist d'un user
        /// </summary>
        /// <param name="manga"></param>
        void AddToReadList(int id, string idstring);

        /// <summary>
        /// Appelle la base pour supprimer un Manga.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        void Delete(int Id);

        /// <summary>
        /// Appelle la base pour supprimer un Manga de la Readlist d'un user.
        /// </summary>
        /// <param name="id"></param>
        void DeleteFromReadList(int id, string idstring);

        /// <summary>
        /// Appelle la base pour editer un Manga.
        /// </summary>
        /// <param name="manga"></param>
        /// <returns></returns>
        void Update(Manga manga);
    }
}
