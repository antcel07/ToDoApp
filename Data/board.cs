using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Data
{
    public class board
    {
        public List<card>? ToDo { get; set; }
        public List<card>? InProgress { get; set; }
        public List<card>? Done { get; set; }
    }
}