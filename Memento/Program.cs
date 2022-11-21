using DesignPatterns.SourceFiles.ObjectPool;
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

#region Object pool

Console.WriteLine("\n-----Object pool Pattern Example-----\n");
Factory factory = new Factory();

Console.WriteLine("Current amount of objects in pool: " + Factory.objPool.Count);
Console.WriteLine("Current amount of acive equipment: " + Equipment.equipmentCounter);
Equipment eq1 = factory.GetEquipment();
Equipment eq2 = factory.GetEquipment();
Equipment eq3 = factory.GetEquipment();
Console.WriteLine("Current amount of objects in pool: " + Factory.objPool.Count);
Console.WriteLine("Current amount of acive equipment: " + Equipment.equipmentCounter);
Equipment eq4 = factory.GetEquipment();
Equipment eq5 = factory.GetEquipment();
Equipment eq6 = factory.GetEquipment();
Console.WriteLine("Current amount of objects in pool: " + Factory.objPool.Count);
Console.WriteLine("Current amount of acive equipment: " + Equipment.equipmentCounter);
factory.DeleteEquipment(eq1);
factory.DeleteEquipment(eq2);
factory.DeleteEquipment(eq3);
Console.WriteLine("Current amount of objects in pool: " + Factory.objPool.Count);
Console.WriteLine("Current amount of acive equipment: " + Equipment.equipmentCounter);
Equipment eq7 = factory.GetEquipment();
Equipment eq8 = factory.GetEquipment();
Console.WriteLine("Current amount of objects in pool: " + Factory.objPool.Count);
Console.WriteLine("Current amount of acive equipment: " + Equipment.equipmentCounter);
Equipment eq9 = factory.GetEquipment();
Equipment eq10 = factory.GetEquipment();
Console.WriteLine("Current amount of objects in pool: " + Factory.objPool.Count);
Console.WriteLine("Current amount of acive equipment: " + Equipment.equipmentCounter);
factory.DeleteEquipment(eq4);
Console.WriteLine("Current amount of objects in pool: " + Factory.objPool.Count);
Console.WriteLine("Current amount of acive equipment: " + Equipment.equipmentCounter);

#endregion