using System.Collections.Generic;
using Windows.Foundation.Collections;

namespace WineCellar.Model
{
    public class Cellar
    {
        [SQLite.PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CellarLine
    {
        [SQLite.PrimaryKey]
        public int Id { get; set; }
        public int CellarId { get; set; }
        public int WineBottleId { get; set; }
        public int Quantity { get; set; }
    }
}