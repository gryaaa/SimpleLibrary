
using System.Text.Json;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Numerics;
using System.Text.RegularExpressions;

namespace LibraryPractice
{
    public partial class SearchBook : Form
    {
        public static List<string> ChossenTags;
        public Library l;
        public SearchBook()
        {
            InitializeComponent();
            ChossenTags = new List<string>();
            l = JsonSerializer.Deserialize<Library>(File.ReadAllText("lib.txt"));
            Library.AllTags = l.Books.SelectMany(b => b.Tags).Distinct().OrderBy(tag => tag).ToList();
            //tableLayoutPanel1.Controls.Add(new BooksDGV(l.Books), 0, 1);
            foreach (var tag in Library.AllTags)
            {
                tagsPanel.Controls.Add(new TagButton() { Text = tag, AutoSize = true });
            }
            //tableLayoutPanel1.Controls.Add(new BooksDGV(l.Books), 0, 1);
            resultButton.Click += (e, a) =>
            {
                tableLayoutPanel1.Controls.Add(new BooksDGV(l.GetMatchedBooks(ChossenTags), l), 0, 1);
            };
        }
        public class TagButton : Button
        {
            public TagButton()
            {
                Click += (e, a) =>
                {
                    if (FlatStyle == FlatStyle.Standard)
                    {
                        FlatStyle = FlatStyle.Popup;
                        ChossenTags.Add(Text);
                    }
                    else
                    {
                        FlatStyle = FlatStyle.Standard;
                        ChossenTags.Remove(Text);
                    }
                };
            }
        }
    }

    public class TagButton : Button
    {
        public TagButton()
        {   
            Click += (e, a) =>
            {
                if (FlatStyle == FlatStyle.Standard)
                    FlatStyle = FlatStyle.Popup;
                else
                    FlatStyle = FlatStyle.Standard;
            };
        }
    }

    public class BooksDGV : DefaultDGW
    {
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn authorColumn;
        private DataGridViewTextBoxColumn GenreColumn;
        private DataGridViewTextBoxColumn PageCountColumn;
        private DataGridViewButtonColumn detailsButtonColumn;
        private List<Book> Books;

        public BooksDGV(List<Book> books, Library l)
        {
            Dock = DockStyle.Fill;

            Books= books;
            idColumn = new DataGridViewTextBoxColumn() { Visible = false };
            nameColumn = new DataGridViewTextBoxColumn() { HeaderText = "Название", FillWeight = 100 };
            authorColumn = new DataGridViewTextBoxColumn() { HeaderText = "Автор", FillWeight = 100 };
            GenreColumn = new DataGridViewTextBoxColumn() { HeaderText = "Жанр", FillWeight = 100 };
            PageCountColumn = new DataGridViewTextBoxColumn() { HeaderText = "Кол-во страниц", FillWeight = 80 };
            detailsButtonColumn = new DataGridViewButtonColumn() { FillWeight = 40 };

            Columns.AddRange(new DataGridViewColumn[] {
            idColumn,
            nameColumn,
            authorColumn,
            GenreColumn,
            PageCountColumn,
            detailsButtonColumn});

            foreach (var book in books)
                Rows.Add(book.Id, book.Name, book.Author, book.Genre, book.PageCount, "Подробнее");

            CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == 5)
                {
                    new BookForm(Books.Single(m => m.Id == (int)Rows[e.RowIndex].Cells[0].Value), l).Show();
                }
            };
        }
    }

    public class DefaultDGW : DataGridView
    {
        public DefaultDGW()
        {
            Dock = DockStyle.Fill;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            ReadOnly = true;
            RowHeadersVisible = false;
        }
    }
}