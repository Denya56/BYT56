using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Mediator
{
    public class TopicChatroom : IChatroom
    {
        public List<Participant> Participants { get; set; }
        public void Send(string msg, Participant participant)
        {

            if (participant.GetType() == typeof(Guest))
                Participants.Find(x => x.GetType().Equals(typeof(Owner))).Notify(msg);
            else
                Participants.Find(x => x.GetType().Equals(typeof(Guest))).Notify(msg);
        }
    }
}
