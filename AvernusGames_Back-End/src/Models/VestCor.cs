using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class VestCor
    {
        public int VestimentaId { get; set; }
        public Vestimenta? Vestimenta { get; set; }

        public int CorId { get; set; }
        public Cor? Cor { get; set; }

        public VestCor() {}

    }
}