using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Models
{
    public class Manga_MangathequeUser
    {
        public int Id { get; set; }

        public int MangaId { get; set; }
        public Manga Manga { get; set; }
        public string MangathequeUserId { get; set; }
        public MangathequeUser MangathequeUser { get; set; }
    }
}
