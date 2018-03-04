using SQLite;

namespace XF_Plugins_12
{
    public class Model
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Info { get; set; }
    }
}
