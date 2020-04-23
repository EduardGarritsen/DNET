using System;

namespace Opdracht4
{
    class Program
    {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday};
        static void Main(string[] args)
        {
            Days d1 = Days.Tuesday;
            Days d2 = Days.Friday;
            Days d3 = Days.Wednesday;

            Days[] days = { d1, d2, d3 };
            foreach (Days d in days)
            {
                Console.WriteLine(DaysInDutch(d));
            }
            Console.ReadKey();
        }

        static string DaysInDutch(Days d)
        {
            string dag = "Geen werkdag";
            switch (d)
            {
                case Days.Monday:
                    dag = "Maandag"; break;
                case Days.Tuesday:
                    dag = "Dinsdag"; break;
                case Days.Wednesday:
                    dag = "Woensdag"; break;
                case Days.Thursday:
                    dag = "Donderdag"; break;
                case Days.Friday:
                    dag = "Vrijdag"; break;
            }
            return dag;
        }
    }
}
