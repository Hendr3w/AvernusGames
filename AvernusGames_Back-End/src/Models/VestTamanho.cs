using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class VestTamanho
    {
        public int VestimentaId { get; set; }
        public Vestimenta? Vestimenta { get; set; }

        public int TamanhoId { get; set; }
        public Tamanho? Tamanho { get; set; }

        public VestTamanho() {}

    }
}