using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryPractice
{
    public partial class AddBookForm : Form
    {
        public Library l;
        public AddBookForm()
        {
            using (var f = new StreamReader("lib.txt", Encoding.UTF8))
                l = JsonSerializer.Deserialize<Library>(f.ReadToEnd());

            InitializeComponent();

            FormClosing +=
                (sender, e) =>
                {
                    using (var f = new StreamWriter("lib.txt", false, Encoding.UTF8))
                        f.Write(JsonSerializer.Serialize(l));
                };

            button1.Click += (e, a) =>
            {
                try
                {
                    var b = new Book()
                    {
                        Id = l.IdEnumerator++,
                        Year = int.Parse(year.Text),
                        Name = name.Text,
                        Genre = genre.Text,
                        Author = author.Text,
                        Tags = tagsBox.Text.UpperSplit(),
                        PageCount = int.Parse(pageCount.Text)
                    };
                    name.Clear();
                    genre.Clear();
                    author.Clear();
                    tagsBox.Clear();
                    pageCount.Clear();
                    year.Clear();
                    l.Books.Add(b);
                }
                catch 
                {
                    MessageBox.Show("Так нельзя", "Error");
                }
            };

        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
