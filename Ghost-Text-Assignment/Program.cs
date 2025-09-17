Console.WriteLine("Boo! Youre a ghost in a haunted mansion!");
Console.WriteLine("Luckily, youre the one haunting it");
Console.WriteLine("");
Console.WriteLine("Its not a mansion if you dont have your favourite room!");
Console.WriteLine("by the way, what is your favourite room in this mansion you call home?");
Console.WriteLine("");
string room = Console.ReadLine();

string favouriteRoom = room;
Console.WriteLine("");
Console.WriteLine($"Wow! The {favouriteRoom} is my favourite room too!");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("You hear something outside... it sounds like a vehicle");
Console.WriteLine("in through the door bursts 4 ghost hunters!");
Console.WriteLine("one of them finds the ouiji board you left out, he asks");
Console.WriteLine("What year did you die?");
Console.WriteLine("");

//finds out how many years ago you died
int death = int.Parse(Console.ReadLine());
int yourDeath = death;
int currentYear = DateTime.Now.Year;
int died = currentYear - yourDeath;
Console.WriteLine("");
Console.WriteLine($"Wow this ghost died {died} years ago!");
Console.WriteLine("");


Console.WriteLine("You see the hutners scramble around a bit more, before one pulls out a small radio like device");
Console.WriteLine("one of the hunters speak into the radio and say");
Console.WriteLine("Do you want to hurt us.");

