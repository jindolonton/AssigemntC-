using System;
namespace T1806_Csharp.Assigment4
{
    public class News : Inews
    {
        public int iD;
        public string title;
        public string publishDate;
        public string author;
        public string content;
        public float averageRate;

        public int[] RateList = new int[3];

        public string Author { get => Author1; set => Author1 = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Title { get => title; set => title = value; }
        public int ID { get => iD; set => iD = value; }
        public float Averagerate { get => averagerate; set => averagerate = value; }
        public string Content { get => content; set => content = value; }

        public News()
        {

        }
        public void Display()
        {
            Console.WriteLine(""+ID);
            Console.WriteLine("" + Title);
            Console.WriteLine("" + PublishDate);
            Console.WriteLine("" + Author);
            Console.WriteLine("" + Content);
            Console.WriteLine("" + AverageRate);
        }

        public int Caculate(int a, int b ,int c)
        {
            return (a + b + c) / 3;
        }
    }
}