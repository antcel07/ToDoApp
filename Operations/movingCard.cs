using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Data;

namespace ToDoApp.Operations
{
    public class movingCard : allOperations
    {
        public override void moveCard()
        {
        againMove:
            Console.WriteLine("Öncelikle taşimak istediğiniz karti seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başligini giriniz            :");
            string? choice = Console.ReadLine();
            var item = database.Card.FirstOrDefault(person => person.Header == choice);
            if(item == null)
            {
            againFail:
                Console.WriteLine("Aradiginiz kriterlere uygun kart board'da bulunamadi. Lütfen bir seçim yapiniz.");
                Console.WriteLine("* İşlemi sonlandirmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                    goto end;
                else if (choice2 == 2)
                    goto againMove;
                else
                {
                    Console.WriteLine("Geçersiz bir karakter girdiniz. Lütfen tekrar deneyiniz.");
                    goto againFail;
                }
            }
            else
            {
            againStatus:
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("***********************");
                Console.WriteLine("Başlik       : {0}", item.Header);
                Console.WriteLine("İçerik       : {0}", item.Content);
                Console.WriteLine("Atanan Kişi  : {0}", item.Person);
                Console.WriteLine("Büyüklük     : {0}", item.Size);
                Console.WriteLine("Line     : {0}", item.Status);
                Console.WriteLine(" ");
                Console.WriteLine("Lütfen taşimak istediğiniz Line'i seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int choiceStatus = Convert.ToInt32(Console.ReadLine());
                if (choiceStatus == 1)
                    item.Status = "ToDo";
                else if (choiceStatus == 2)
                    item.Status = "InProgress";
                else if (choiceStatus == 3)
                    item.Status = "Done";
                else
                {
                    Console.WriteLine("Yanliş bir karakter girdiniz.");
                    Console.WriteLine("Çikmak için : (1)");
                    Console.WriteLine("Yeniden denemek için : (2)");
                    int choiceExitOrNot = Convert.ToInt32(Console.ReadLine());
                    if (choiceExitOrNot == 1)
                        goto end;
                    else if (choiceExitOrNot == 2)
                        goto againStatus;
                }
                listingAllCard list = new listingAllCard();
                list.listCard();
            }
        end:;
        }
    }
}