using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Memento
{
    public class Memento
    {
        public string time { get; set; }
        public Memento(string time)
        {
            this.time = time;
        }
    }
}
