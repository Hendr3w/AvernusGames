using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class VestMaterial
    {
        public int VestimentaId { get; set; }
        public Vestimenta? Vestimenta { get; set; }

        public int MaterialId { get; set; }
        public Material? Material { get; set; }

        public VestMaterial() {}

    }
}