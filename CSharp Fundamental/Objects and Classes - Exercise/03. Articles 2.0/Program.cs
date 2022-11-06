using System;
using System.Collections.Generic;
using System.Linq;
using static _02._Articles.Program;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Article> articleList = new List<Article>();
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string title = command[0];
                string content = command[1];
                string author = command[2];
                Article article = new Article(title, content, author);
                articleList.Add(article);
            }         
                foreach (Article article in articleList)
                {
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
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }
        }

    }
}

