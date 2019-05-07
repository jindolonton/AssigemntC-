using System;
namespace T1806_Csharp.Assigment4
{
    public class Program

    {
        private Manager manager;

        public Manager Manager { get => manager; set => manager = value; }

        public static void Main(string[] args)
        {
            do
            {
                manager.Menu();
                int luachon = int.Parse(Console.ReadLine);
                while (luachon > 4)
                {
                    Console.WriteLine("choose again");

                }

                switch (luachon)
                {
                    case 1:
                        
                        manager.Nhap();
                        manager.addNews();
                        break;
                    case 2:
                        manager.Display();
                        break;

                    case 3:
                        manager.AverageRate();
                        manager.Display();
                        break;
                    case 4:
                        break;


                }

            } while (luachon != 4);
            


        }
    }
}