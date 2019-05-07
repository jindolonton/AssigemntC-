using System;
namespace T1806_Csharp.Assigment4
{
    public class Manager
    {
        public News news;
        public List<News> newsList = new List<News>();
        public void Menu()
        {
            Console.WriteLine("Chon chuc nanng:");
            Console.WriteLine("1. Insert News");
            Console.WriteLine("2.  View list news");
            Console.WriteLine("3. Average rate ");
            Console.WriteLine("4. exit");


        }
        public void Nhap()
        {
            Console.Write("ID:");
            news.ID = int.Parse(Console.ReadLine);
            Console.Write("title:");
            news.Title = Console.ReadLine;
            Console.Write("publishDate:");
            news.PublishDate = Console.ReadLine;
            Console.Write("Author:");
            news.Author = Console.ReadLine;
            Console.Write("Content:");
            news.Content = Console.ReadLine;
            Console.Write("AverageRate 1:");
            news.RateList[0] = float.Parse(Console.ReadLine);
            Console.Write("AverageRate 2:");
            news.RateList[1] = float.Parse(Console.ReadLine);

            Console.Write("AverageRate 3:");
            news.RateList[3] = float.Parse(Console.ReadLine);
           



        }
        public void addNews(News news)
        {
            Nhap();
            news.averageRate = AverageRare;
            newsList.Add(news(news.Title,news.PublishDate,news.Author,news.Content,news.AverageRate));

        }
        public float AverageRare()
        {
            return  news.Caculate(RareList[0], RateList[1], RateList[2]);
        }

        public void Display()
        {
            foreach(List<News> list in newsList)
            {
                Console.WriteLine(list);
            }
        }

    }
}