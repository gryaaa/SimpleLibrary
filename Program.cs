using System.Text.Json;
using System.Windows.Forms;

namespace LibraryPractice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SearchBook());
        }
    }

    public class Library
    {
        public int IdEnumerator { get; set; }
        public static List<string> AllTags { get; set; }
        public List<Book> Books { get; set; }
        public List<Reader> Readers { get; set; }
        public Library()
        {
            //Books = JsonConvert.DeserializeObject(File.ReadAllText("huli")) as List<Book>;
            //AllTags = Books.SelectMany(b => b.Tags).Where(t => (!AllTags.Contains(t))).ToList();
        }

        public List<Book> GetMatchedBooks(List<string> ChosenTags)
        {
            var dict = new Dictionary<Book, int>();
            foreach (var book in Books)
            {
                dict[book] = book.Tags.Intersect(ChosenTags).Count();
            }
            var resultDict = dict.Where(pair => pair.Value > 0).OrderByDescending(pair => pair.Value);
            return resultDict.Select(pair => pair.Key).ToList();
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public List<string> Tags { get; set; }
        public int PageCount { get; set; }

        public void AddTeg(string tag) 
        {
            Tags.Add(tag);
        }
        public void RemoveTeg(string tag) 
        {
            Tags.Remove(tag);
        }
    }

    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> LikedBooks { get; set; }
        public List<string> LikedTags { get; set; }
    }
        
    public static class Infrastructure
    {
        public static List<string> UpperSplit(this string text)//разделение текста на словосочетания/слова, которые начинаются с большой буквы
        {
            var list = new List<string>();
            int start = 0;
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    list.Add(text.Substring(start, i - start));
                    start = i;
                }
                else if(i == text.Length - 1)
                {
                    list.Add(text.Substring(start, i - start+1));
                    break;
                }
            }
            return list.Select(b=>b.Trim()).ToList();
        }
    }
}