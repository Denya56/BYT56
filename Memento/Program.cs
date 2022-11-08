using Memento.SourceFiles.Mediator;
using Memento.SourceFiles.Memento;

#region Memento
Console.WriteLine("=====Memento Pattern Example=====\n");
CareTaker ct = new CareTaker();
ct.mementos = new List<Memento.SourceFiles.Memento.Memento>();
Life life = new Life();
life.time = "1000 B.C.";
ct.mementos.Add(life.SaveToMemento());
life.time = "1000 A.D.";
ct.mementos.Add(life.SaveToMemento());
life.time = "100 B.C.";
ct.mementos.Add(life.SaveToMemento());
life.time = "100 A.D.";
ct.mementos.Add(life.SaveToMemento());

life.RestoreFromMemento(ct.mementos.Last());
#endregion

#region Mediator
Console.WriteLine("\n-----Mediator Pattern Example-----\n");
TopicChatroom chatroom = new TopicChatroom();
chatroom.Participants = new List<Participant>();
Guest guest = new Guest(chatroom);
Owner owner = new Owner(chatroom);
chatroom.Participants.Add(guest);
chatroom.Participants.Add(owner);
guest.Send("Hello! Did you see a new product");
owner.Send("No, not yet");
guest.Send("Oh ok");
#endregion