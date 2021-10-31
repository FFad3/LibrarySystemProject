using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;
using System.IO;
//classes

namespace LibrarySystemProject
{
    public partial class LibrarySysLogin : Form
    {
        public SQLiteConnection db =null;
        public LibrarySysLogin()
        {
            InitializeComponent();
            CreateDatabase();
            CreateUsersTable();
        }
        void CreateDatabase()
        {
          db = new SQLiteConnection("MyDatabase.db3");
        }
        void CreateUsersTable()
        {
          db.CreateTable<UserModel>();
          IList<UserModel> userList = new List<UserModel>();
          userList = db.Table<UserModel>().ToList();

          if (userList.Count()<2)
          {
                db.Insert(new UserModel() { Username = "Admin", Password = "Admin", Permission = 1 });
                db.Insert(new UserModel() { Username = "User", Password = "User", Permission = 0 });
          }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var table = db.Query<UserModel>("SELECT * FROM UserModel WHERE Username='"+UsernameInput.Text+"' And Password='"+PasswordInput.Text+"'");
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            foreach (var s in table)
            {
                UserModel user;
                user = db.Table<UserModel>().Where(i => i.Password == password && i.Username == username).FirstOrDefault();
                LoginResult.PermissionValue = user.Permission;
                LibrarySys menu = new LibrarySys();
                this.Hide();
                menu.Show();
                break;
            }
            UsernameInput.Text = "";
            PasswordInput.Text = "";
        }
    }
}
