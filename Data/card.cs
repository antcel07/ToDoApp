using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToDoApp.Data
{
    public class card
    {
        public string? Header { get; set; }
        public string? Content { get; set; }
        public string? Size { get; set; }
        public string? Person { get; set; }
        public string? Status { get; set; }
    }
    
}