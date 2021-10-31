using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LibrarySystemProject
{
    class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public uint Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
    }
}
