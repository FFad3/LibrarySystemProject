using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LibrarySystemProject
{
    class BookModel
    {
        [PrimaryKey, AutoIncrement]
        public uint Id { get; set; }
        public string Tittle { get; set; }
        public string Author { get; set; }
        public int RealeaseDate { get; set; }
        public string Publisher { get; set; }
        public int IsAvailable { get; set; }
    }
}
