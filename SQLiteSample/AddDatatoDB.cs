using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SQLiteSample
{
    public partial class AddDatatoDB : Form
    {

        public String Author { get; set; }
        public String Book { get; set; }

        public AddDatatoDB()
        {
            InitializeComponent();
        }

        private void AddDatatoDB_Load(object sender, EventArgs e)
        {
            Author = "Author";
            Book = "Book";

            tbAuthor.Text = Author;
            tbBook.Text = Book;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Author = tbAuthor.Text;
            Book = tbBook.Text;

            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
