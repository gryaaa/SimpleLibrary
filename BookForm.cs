using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryPractice
{
    public partial class BookForm : Form
    {
        public BookForm(Book book, Library library)
        {
            InitializeComponent();
            tagsPanel.AutoScroll= true;
            nameLabel.Text = book.Name;
            authorLabel.Text = book.Author;
            YearLabel.Text = book.Year.ToString();
            GenreLabel.Text = book.Genre;
            PageCountLabel.Text = book.PageCount.ToString();

            foreach (var tag in book.Tags)
            {
                tagsPanel.Controls.Add(new TagButton { Text = tag, Enabled = false, AutoSize = true }) ;
            }

            booksPanel.Controls.Add(new BooksDGV(library.GetMatchedBooks(book.Tags), library), 0, 1);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void authorLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
