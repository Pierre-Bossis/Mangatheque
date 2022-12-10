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
        List<Manga> GetList();

        /// <summary>
        /// Appelle la base pour retourner un Manga.
        /// </summary>
        /// <returns></returns>
        Manga GetOne(int Id);

        /// <summary>
        /// Permet l'ajout d'un nouveau Manga en base de donnée.
        /// </summary>
        void AddOne(Manga manga);
    }
}
