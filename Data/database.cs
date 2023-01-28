using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Data
{
    public class database
    {
        private static List<card> _cards;
        private static List<person> _persons;
        static database()
        {
            _cards = new List<card>()
            {
                new card()
                {
                    Header = "Tamir",
                    Content = "Lastiklerin değiştirilmesi",
                    Size = "XL",
                    Person = "Semih",
                    Status = "InProgress"
                },
                new card()
                {
                    Header = "Yazilim",
                    Content = "Kodlarin canliya alinmadan test işlemlerinin yapilmasi",
                    Size = "L",
                    Person = "İsmail",
                    Status = "Done"
                },
                new card()
                {
                    Header = "Rapor",
                    Content = "Günlük yapilan hasilatin z raporu çikarilmasi",
                    Size = "S",
                    Person = "Eda",
                    Status = "ToDo"
                }
            };
            _persons = new List<person>()
            {
                new person()
                {
                    Name = "Tarik",
                    Team = "Tamir",
                    ID = 1
                },
                new person()
                {
                    Name = "Bayram",
                    Team = "Yazilim",
                    ID = 2
                },
                new person()
                {
                    Name = "Sedef",
                    Team = "Rapor",
                    ID = 3
                }
            };
        }
        public static List<card> Card => _cards;
        public static List<person> Person => _persons;
    }
}