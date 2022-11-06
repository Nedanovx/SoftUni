using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> articleList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string title = articleList[0];
            string content = articleList[1];
            string author = articleList[2];

            Article article = new Article (title, content, author);

            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cmdArg = command[0];
                if(cmdArg == "Edit")
                {
                    string newContent = command[1];
                    article.Edit (newContent);
                }
                else if(cmdArg == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if(cmdArg == "Rename")
                {
                    string newTitle = command[1];
                    article.Rename(newTitle);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename (string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        
    }
}
