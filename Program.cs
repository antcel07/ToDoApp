using System.Diagnostics;
using System.Linq.Expressions;
using ToDoApp.Operations;

while (true)
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) Board Listelemek");
    Console.WriteLine("(2) Board'a Kart Eklemek");
    Console.WriteLine("(3) Board'dan Kart Silmek");
    Console.WriteLine("(4) Kart Taşimak");
    Console.WriteLine("(5) Uygulamadan Çikiş Yapmak");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            listingAllCard list = new listingAllCard();
            list.listCard();
            break;
        case "2":
            addingCard add = new addingCard();
            add.addCard();
            break;
        case "3":
            deletingCard delete = new deletingCard();
            delete.deleteCard();
            break;
        case "4":
            movingCard move = new movingCard();
            move.moveCard();
            break;
        case "5":
            goto end;           
    }
}
end:;