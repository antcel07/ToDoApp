using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Data;

namespace ToDoApp.Operations
{
    public class listingAllCard : allOperations
    {
        private static board _Boards;

        public void LineTheBoard()
        {
            var toDo = database.Card.Where(x => x.Status == "ToDo").ToList();
            var inProgress = database.Card.Where(x => x.Status == "InProgress").ToList();
            var done = database.Card.Where(x => x.Status == "Done").ToList();

            _Boards = new board();
            _Boards.ToDo = toDo;
            _Boards.InProgress = inProgress;
            _Boards.Done = done;
        }
        public override void listCard()
        {
            LineTheBoard();
            DisplayTheCard(" TODO Line", _Boards.ToDo);
            DisplayTheCard(" IN PROGRESS Line", _Boards.InProgress);
            DisplayTheCard(" DONE Line", _Boards.Done);

        }
        public void DisplayTheCard(string boardType, List<card>? listName)
        {
            Console.WriteLine(boardType);
            Console.WriteLine("****************************");
            foreach (var item in listName)
            {
                Console.WriteLine("Başlik      : {0}", item.Header);
                Console.WriteLine("İçerik      : {0}", item.Content);
                Console.WriteLine("Atanan Kişi : {0}", item.Person);
                Console.WriteLine("Büyüklük    : {0}", item.Size);
                Console.WriteLine("-");
            }
        }
    }
}