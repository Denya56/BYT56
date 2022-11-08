using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Mediator
{
    public class Guest : Participant
    {
        public Guest(IChatroom chatroom) : base(chatroom) { }
        public override void Notify(string message)
        {
            Console.WriteLine($"To guest: {message}");
        }
    }
}
