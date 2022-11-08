using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Mediator
{
    public abstract class Participant
    {
        protected IChatroom IChatroom;
        public Participant(IChatroom chatroom)
        {
            IChatroom = chatroom;
        }
        public abstract void Notify(string message);
        public virtual void Send(string message)
        {
            IChatroom.Send(message, this);
        }
    }
}
