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
namespace LibrarySystemProject
{
    public partial class LibrarySys : Form
    {
        public SQLiteConnection db = new SQLiteConnection("MyDatabase.db3");
        public int perm;
        public LibrarySys()
        {
            InitializeComponent();
            CreateDatabase();
            CreateUsersTable();
            perm=LoginResult.PermissionValue;
            if (perm==0)
            {
                AddButton.Visible=false;
                DeleteButton.Visible = false;
            }
        }
        void CreateUsersTable()
        {
            db.CreateTable<BookModel>();
            IList<BookModel> bookList = new List<BookModel>();
            bookList = db.Table<BookModel>().ToList();

            if (bookList.Count() < 3)
            {
                                                                                //  Id Tittle Author RealeaseDatePublisher Access 
                db.Insert(new BookModel() { Tittle = "stary czlowiek i morze", Author = "Ernest Hemingway", RealeaseDate = 1951, Publisher = "morze bałtyckie", IsAvailable = 1 });
                db.Insert(new BookModel() { Tittle = "krzyzacy", Author = "Henryk Sienkiewicz", RealeaseDate = 1900, Publisher = "mloda polska", IsAvailable = 0 });
                db.Insert(new BookModel() { Tittle = "quo vadis", Author = "Henryk Sienkiewicz", RealeaseDate = 1895, Publisher = "kijwiekto", IsAvailable = 1 });
            }
        }
        void CreateDatabase()
        {
            db = new SQLiteConnection("MyDatabase.db3");
        }
        void DataGridDisplay()
        {
            List<BookModel> displayBooklist = new List<BookModel>();
            displayBooklist = db.Table<BookModel>().ToList();
            dataGridView1.DataSource = displayBooklist;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            int errorSum = 0;
            if (Tittleinput.Text.Length == 0)
            {
                errorSum =+ 1;
            }
            if (Author.Text.Length == 0)
            {
                errorSum = +1;
            }
            if (ReleaseDateinput.Text.Length == 0)
            {
                errorSum = +1;
            }
            if (Publisherinput.Text.Length == 0)
            {
                errorSum = +1;
            }
            if(errorSum==0)
            {
                db.Insert(new BookModel()
                {
                    Tittle = Tittleinput.Text,
                    Author = Authorinput.Text,
                    RealeaseDate = Int32.Parse(ReleaseDateinput.Text),
                    Publisher = Publisherinput.Text,
                    IsAvailable=1
            });
                Tittleinput.Text = "";
                Authorinput.Text = "";
                ReleaseDateinput.Text = "";
                Publisherinput.Text = "";
                MessageBox.Show("Book Added");
            }
            else { MessageBox.Show("error Enter ale date"); };
            DataGridDisplay();         
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DataGridDisplay();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = $"select * from BookModel where Id like '%{IDinput.Text}%' and Tittle like '%{Tittleinput.Text}%'and Author like '%{Authorinput.Text}%'and RealeaseDate like '%{ReleaseDateinput.Text}%' and Publisher like '%{Publisherinput.Text}%'";
            IList<BookModel> searchList = new List<BookModel>();
            searchList = db.Query<BookModel>(search).ToList();
            dataGridView1.DataSource = searchList;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            db.Delete(new BookModel() { Id = (uint.Parse(SelectedID.Text))});
            DataGridDisplay();
            MessageBox.Show("Book Deleted");
            SelectedID.Text = "";
        }
        private void RentButton_Click(object sender, EventArgs e)
        {
                string setAvaiable = $"update BookModel set IsAvailable='0' where Id='{SelectedID.Text}'";
                IList<BookModel> rente = new List<BookModel>();
                rente = db.Query<BookModel>(setAvaiable).ToList();
                DataGridDisplay();
                MessageBox.Show("rented");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string setAvaiable = $"update BookModel set IsAvailable='1' where Id='{SelectedID.Text}'";
            IList<BookModel> rente = new List<BookModel>();
            rente = db.Query<BookModel>(setAvaiable).ToList();
            DataGridDisplay();
            MessageBox.Show("returned");
        }
    }
}
