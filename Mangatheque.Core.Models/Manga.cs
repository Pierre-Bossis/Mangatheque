using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Models
{
    public class Manga
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public int Numero { get; set; }

        public string Auteur { get; set; }

        public string Genre { get; set; }

        public DateTime DatePublication { get; set; }
        public byte[]? Couverture { get; set; }

        public Stock stock { get; set; } = Stock.Valid;

        //public List<MangasUser>? MangasUser { get; set; }

    }
}
