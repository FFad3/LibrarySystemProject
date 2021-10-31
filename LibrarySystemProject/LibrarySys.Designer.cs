namespace LibrarySystemProject
{
    partial class LibrarySys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarySys));
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RentButton = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.IDinput = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.Tittleinput = new System.Windows.Forms.TextBox();
            this.Authorinput = new System.Windows.Forms.TextBox();
            this.ReleaseDateinput = new System.Windows.Forms.TextBox();
            this.Publisherinput = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.SelectedID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogin
            // 
            this.pictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogin.Image")));
            this.pictureLogin.Location = new System.Drawing.Point(674, 400);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(120, 45);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogin.TabIndex = 1;
            this.pictureLogin.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.Location = new System.Drawing.Point(113, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 41);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add book";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Location = new System.Drawing.Point(149, 400);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 38);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete book";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AccessibleName = "SearchButton";
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.Location = new System.Drawing.Point(4, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(103, 41);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RentButton
            // 
            this.RentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RentButton.Location = new System.Drawing.Point(18, 400);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(120, 38);
            this.RentButton.TabIndex = 5;
            this.RentButton.Text = "Rent book";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // Return
            // 
            this.Return.AccessibleName = "Return";
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Return.Location = new System.Drawing.Point(18, 356);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(120, 38);
            this.Return.TabIndex = 7;
            this.Return.Text = "Return book";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 311);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DisplayButton.Location = new System.Drawing.Point(668, 14);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(120, 39);
            this.DisplayButton.TabIndex = 10;
            this.DisplayButton.Text = "Display books";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // IDinput
            // 
            this.IDinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDinput.Location = new System.Drawing.Point(96, 63);
            this.IDinput.Name = "IDinput";
            this.IDinput.Size = new System.Drawing.Size(171, 29);
            this.IDinput.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id.Location = new System.Drawing.Point(53, 66);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(37, 24);
            this.Id.TabIndex = 12;
            this.Id.Text = "ID :";
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tittle.Location = new System.Drawing.Point(31, 101);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(59, 24);
            this.Tittle.TabIndex = 13;
            this.Tittle.Text = "Tittle :";
            // 
            // Tittleinput
            // 
            this.Tittleinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tittleinput.Location = new System.Drawing.Point(96, 98);
            this.Tittleinput.Name = "Tittleinput";
            this.Tittleinput.Size = new System.Drawing.Size(171, 29);
            this.Tittleinput.TabIndex = 14;
            // 
            // Authorinput
            // 
            this.Authorinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Authorinput.Location = new System.Drawing.Point(96, 133);
            this.Authorinput.Name = "Authorinput";
            this.Authorinput.Size = new System.Drawing.Size(171, 29);
            this.Authorinput.TabIndex = 15;
            // 
            // ReleaseDateinput
            // 
            this.ReleaseDateinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReleaseDateinput.Location = new System.Drawing.Point(138, 171);
            this.ReleaseDateinput.Name = "ReleaseDateinput";
            this.ReleaseDateinput.Size = new System.Drawing.Size(129, 29);
            this.ReleaseDateinput.TabIndex = 16;
            // 
            // Publisherinput
            // 
            this.Publisherinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Publisherinput.Location = new System.Drawing.Point(113, 206);
            this.Publisherinput.Name = "Publisherinput";
            this.Publisherinput.Size = new System.Drawing.Size(154, 29);
            this.Publisherinput.TabIndex = 17;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author.Location = new System.Drawing.Point(14, 136);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(76, 24);
            this.Author.TabIndex = 18;
            this.Author.Text = "Author :";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReleaseDate.Location = new System.Drawing.Point(8, 174);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(127, 24);
            this.ReleaseDate.TabIndex = 19;
            this.ReleaseDate.Text = "ReleaseDate :";
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Publisher.Location = new System.Drawing.Point(8, 209);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(99, 24);
            this.Publisher.TabIndex = 20;
            this.Publisher.Text = "Publisher :";
            // 
            // SelectedID
            // 
            this.SelectedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectedID.Location = new System.Drawing.Point(149, 365);
            this.SelectedID.Name = "SelectedID";
            this.SelectedID.Size = new System.Drawing.Size(80, 29);
            this.SelectedID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(144, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select ID";
            // 
            // LibrarySys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedID);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Publisherinput);
            this.Controls.Add(this.ReleaseDateinput);
            this.Controls.Add(this.Authorinput);
            this.Controls.Add(this.Tittleinput);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.IDinput);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pictureLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibrarySys";
            this.Text = "LibrarySys";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.TextBox IDinput;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.TextBox Tittleinput;
        private System.Windows.Forms.TextBox Authorinput;
        private System.Windows.Forms.TextBox ReleaseDateinput;
        private System.Windows.Forms.TextBox Publisherinput;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.TextBox SelectedID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}