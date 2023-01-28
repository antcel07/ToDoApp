using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ToDoApp.Data;

namespace ToDoApp.Operations
{
    public class deletingCard : allOperations 
    {
        public override void deleteCard()
        {
        againDelete:
            Console.WriteLine("Öncelikle silmek istediğiniz karti seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başligini yazinz             :");
            string? choose = Console.ReadLine();
            database person = new database();
            var item = database.Card.FirstOrDefault(x => x.Header == choose);
            if (item != null)
            {
                database.Card.Remove(item);
                Console.WriteLine("Silme işlemi başariyla tamamlandi.");
            }
            else
            {
                Console.WriteLine("Aradiginiz kriterlere uygun bir kart bulunamadi.");
                Console.WriteLine("* Silmeyi sonlandirmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int chooseNumber = Convert.ToInt32(Console.ReadLine());
                if (chooseNumber == 1)
                    goto endingDelete;
                else if (chooseNumber == 2)
                    goto againDelete;

            }
        endingDelete:;
        }
    }
}