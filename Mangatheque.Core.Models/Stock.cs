using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Models
{
    public record Stock
    {
        public static Stock Valid = new Stock() { Id = 1, Label = "Disponible" };
        public static Stock Soon = new Stock() { Id = 0, Label = "Bientôt disponible" };
        public static Stock Invalid = new Stock() { Id = -1, Label = "Indisponible" };

        public decimal Id { get; init; }

        public string Label { get; set; } = default!;


    }
}
