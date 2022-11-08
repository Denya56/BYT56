using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.SourceFiles.Mediator
{
    public class SubjectChatroom : IChatroom
    {
        public Participant Student { get; set; }
        public Participant Teacher { get; set; }
        public List<Participant> Participants { get; set; }
        public void Send(string msg, Participant participant)
        {
            
            if (participant.GetType() == typeof(Student))
                Participants.Find(x => x.GetType().Equals(typeof(Teacher))).Notify(msg);
            else
                Participants.Find(x => x.GetType().Equals(typeof(Student))).Notify(msg);
        }
    }
}
