using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCellar.Model
{
    public class WineBottle
    {
        [SQLite.PrimaryKey]
        public int Id { get; set; }
        public int Year { get; set; }
        public int DominantGrapeId { get; set; }
        public int DrinkingFrom { get; set; }
        public int DrinkingTo { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public decimal Cost { get; set; }
        public string Currency { get; set; }
    }
}

