using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfArcicles = int.Parse(Console.ReadLine());
            List<Articles> articlesi = new List<Articles>();

            for (int i = 0; i < numbersOfArcicles; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Articles newArticles = new Articles(title, content, author);
                articlesi.Add(newArticles);
            }

            string typeOperation = Console.ReadLine();
            if(typeOperation== "title")
            {
                articlesi = articlesi.OrderBy(x => x.Title).ToList();
            }
            else if (typeOperation == "content")
            {
                articlesi = articlesi.OrderBy(x => x.Content).ToList();
            }
            else if (typeOperation == "author")
            {
                articlesi = articlesi.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine,articlesi));
        }
    }

    class Articles
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Articles()
        {
            this.Title = null;
            this.Content = null;
            this.Author = null;
        }
        public Articles(string title,string content,string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";

        }
    }
}
