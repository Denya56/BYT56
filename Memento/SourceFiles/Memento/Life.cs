using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Memento
{
    public class Life
    {
        public string time { get; set; }

        public Memento SaveToMemento()
        {
            Console.WriteLine($"Saving time {time} to Memento");
            return new Memento(time);
        }
        public void RestoreFromMemento(Memento memento)
        {
            time = memento.time;
            Console.WriteLine($"Time restored from Memento: {time}");
        }
    }
}
