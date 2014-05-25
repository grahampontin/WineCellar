namespace WineCellar.Model
{
    public class Grape
    {
        [SQLite.PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}