using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Mediator
{
    public class Owner : Participant
    {
        public Owner(IChatroom chatroom) : base(chatroom) { }
        public override void Notify(string message)
        {
            Console.WriteLine($"To owner: {message}");
        }
    }
}
