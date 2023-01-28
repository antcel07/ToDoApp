using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ToDoApp.Data;

namespace ToDoApp.Operations
{
    public class addingCard : allOperations
    {
        card newCard = new card();
        public override void addCard()
        {
        againId:
            Console.WriteLine("Kart Ekleme Alani");
            Console.WriteLine("********************************");

            Console.WriteLine("Başligini giriniz          :");
            newCard.Header = Console.ReadLine();

            Console.WriteLine("İçeriğini giriniz          :");
            newCard.Content = Console.ReadLine();

            Console.WriteLine("Kişiyi seçiniz             :");
            newCard.Person = Console.ReadLine();

            Console.WriteLine("Lütfen durumunu seçiniz (1) To-Do (2) In Progress (3) Done :");
            int choosingStatus = Convert.ToInt32(Console.ReadLine());
            if (choosingStatus == 1)
                newCard.Status = "ToDo";
            else if (choosingStatus == 2)
                newCard.Status = "InProgress";
            else if (choosingStatus == 3)
                newCard.Status = "Done";
            else
                Console.WriteLine("Yanliş bir karakter girdiniz.");

            Console.WriteLine("Boyutunu seçiniz (1)XS (2)S (3)M (4)L (5)XL");
            int choosingSize = Convert.ToInt32(Console.ReadLine());
            string choosingSizeString = Enum.GetName(typeof(size), choosingSize);
            newCard.Size = choosingSizeString;
            CheckingTheId();
        }

        public void CheckingTheId()
        {
        againId:
            database idCheck = new database();
            Console.WriteLine("Lütfen ID numaranizi giriniz    :");
            int id = Convert.ToInt32(Console.ReadLine());
            var item = database.Person.FirstOrDefault(x => x.ID == id);
            if (item != null)
            {
                database.Card.Add(newCard);
                Console.WriteLine("Yeni kart {0} tarafindan oluşturulmuştur.", item.Name );
            }
            else
            {
                Console.WriteLine("Yanliş bir değer girdiniz. Tekrar denemek için (1)");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                    goto againId;
            }
        }
    }
    enum size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}