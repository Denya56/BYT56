using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Mediator
{
    public interface IChatroom
    {
        public abstract void Send(string msg, Participant participant);
    }
}
