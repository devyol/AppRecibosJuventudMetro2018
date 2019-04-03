using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MET01.UI.Clases
{
    public class Mensaje<T>
    {
        public int codigo { get; set; }
        public string mensaje { get; set; }
        public string error { get; set; }
        public int totalvalores { get; set; }
        public T data { get; set; }
        public Mensaje() { }
    }
}
