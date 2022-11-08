using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Mediator
{
    public class Teacher : Participant
    {
        public Teacher(IChatroom chatroom) : base(chatroom) { }
        public override void Notify(string message)
        {
            Console.WriteLine($"To teacher: {message}");
        }
    }
}
