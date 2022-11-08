using Memento.SourceFiles.Mediator;
using Memento.SourceFiles.Memento;

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

Console.WriteLine("\n-----Mediator Pattern Example-----\n");
SubjectChatroom chatroom = new SubjectChatroom();
chatroom.Participants = new List<Participant>();
Student student = new Student(chatroom);
Teacher teacher = new Teacher(chatroom);
chatroom.Participants.Add(student);
chatroom.Participants.Add(teacher);
chatroom.Student = student;
chatroom.Teacher = teacher;
student.Send("Hello! Did you already checked our test?");
teacher.Send("No, not yet");
student.Send("Oh ok");