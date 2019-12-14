using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Articles = Console.ReadLine().Split(",", ' ');
            int n = int.Parse(Console.ReadLine());
            string title = Articles[0];
            string content = Articles[1];
            string author = Articles[2];

            Articles newArcticle = new Articles(title,content,author);


            for (int i = 0; i < n; i++)
            {
                string [] comand = Console.ReadLine().Split(":");
                string actualComand = comand[0];
                if(actualComand== "Edit")
                {
                    newArcticle.Edit(comand[1]);
                }
                else if(actualComand== "ChangeAuthor")
                {
                    newArcticle.ChangeAuthor(comand[1]);
                }
                else if(actualComand== "Rename")
                {
                    newArcticle.Rename(comand[1]);
                }
                    
            }
            Console.WriteLine(newArcticle);
        }

    }

    class Articles
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Articles(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
         return $"{this.Title} -{this.Content}:{this.Author}";
            
        }
    }
}
