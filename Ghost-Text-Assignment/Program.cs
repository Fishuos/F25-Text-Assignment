Console.WriteLine("Narrator: Boo! Youre a ghost in a haunted mansion!");
Console.WriteLine("Narrator: Luckily, you're the one haunting it.");
Console.WriteLine("");
Console.WriteLine("Narrator: Its not a mansion if you dont have your favourite room!");
Console.WriteLine("Narrator: By the way, what is your favourite room in this mansion you call home?");
Console.WriteLine("");
string favouriteRoom = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine($"Narrator: Wow! The {favouriteRoom} is my favourite room too!");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Narrator: You hear something outside... it sounds like a vehicle.");
Console.WriteLine("Narrator: In through the door bursts 4 ghost hunters!");
Console.WriteLine("Narrator: One of them finds the ouiji board you left out, he asks...");
Console.WriteLine("Hunter: What year did you die?");
Console.WriteLine("");

//finds out how many years ago you died
int death = int.Parse(Console.ReadLine());
int currentYear = DateTime.Now.Year;
int died = currentYear - death;
Console.WriteLine("");
Console.WriteLine($"Hunter: Wow this ghost died {died} years ago!");
Console.WriteLine("");


Console.WriteLine("Narrator: You see the hunters scramble around a bit more, before one pulls out a small radio like device.");
Console.WriteLine("Narrator: One of the hunters speak into the radio and say...");
Console.WriteLine("Hunter: Do you wish to hurt us.");

string hurt = Console.ReadLine();


if  (hurt.ToLower() == "yes")
{
    Console.WriteLine("Hunter: Guys i'd be careful, this ghost seems agressive!");
}

else if (hurt.ToLower() == "no")
{
    Console.WriteLine("Hunter: The Ghost seems friendly! lets try not to change that..");
}

else
{
    Console.WriteLine($"Hunter: {hurt}...., this ghost seems a bit strange...");
}

Console.WriteLine("");
Console.WriteLine("Narrator: You hear a flick come from the basement, followed by...");
Console.WriteLine("Hunter: Generators on!");
Console.WriteLine("Narrator: You see one of the hunters flick a light switch on, and the blaring lights come to life.");
Console.WriteLine("Narrator: do you wish to leave the light on, or turn it back off?");
Console.WriteLine("");

string lights = Console.ReadLine();
string findOn = "on";
string findOff = "off";

//looks for the word "on", incase user types "turn on" instead of just "on"
if (lights.Contains(findOn))
{
    Console.WriteLine("Narrator: You leave the lights on, but start to get this strange feeling.");
    Console.WriteLine("Narrator: Your head starts pounding, and you start feeling dizzy.");
    Console.WriteLine("Narrator: You snap out of it, and as you do the light bulbs in the room explode, leaving you in darkness.");
}
//looks for the word "off", incase user types "turn off" instead of just "off"
else if (lights.Contains(findOff))
{
    Console.WriteLine("Narrator: you rush to the lights as fast as you can and switch them back off.");
    Console.WriteLine("Narrator: The hunters flinch at this suddon action.");
}

else
{
    Console.WriteLine($"Narrator: {lights} is invalid");
    Console.WriteLine("Narrator: You leave the lights on, but start to get this strange feeling.");
    Console.WriteLine("Narrator: Your head starts pounding, and you start feeling dizzy.");
    Console.WriteLine("Narrator: You snap out of it, and as you do the light bulbs in the room explode, leaving you in darkness.        ");
}



Console.WriteLine("");
Console.WriteLine("Hunter: Lets leave this room, I dont think the ghost wants us here.");
Console.WriteLine($"Narrator: You see the hunters enter the {favouriteRoom}");
Console.WriteLine("Narrarator: you see one of the hunters pull out a video recorder, and start pointing it around the room.");
Console.WriteLine("Hunter: I see ghost orbs! This must be its room! Go grab the book and see if they write their name in it.");
Console.WriteLine("Narrator: You see one of the hunters leave for a moment before coming back and placing a book on the floor.");
Console.WriteLine("Narrator: What is your name?");
Console.WriteLine("");

string name = Console.ReadLine();

Console.WriteLine($"Hunter: Wait... this is THE {name}... We gotta get out of here!");
Console.WriteLine("Narrator: you see all of the hunters scramble out of the building as fast as they can, leaving behind equiptment and a single journal.");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");


// Repeats the overall gathered info 
Console.WriteLine("Ghost Hunting Journal.");
Console.WriteLine("");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Time since death: {died} years");
Console.WriteLine($"Favourite room: {favouriteRoom}");


if (hurt.ToLower() == "yes")
{
    Console.WriteLine("Mood: Agressive");
}

else if (hurt.ToLower() == "no")
{
    Console.WriteLine("Mood: Friendly");
}

else
{
    Console.WriteLine("Mood: Unknown...");
}

if (lights.Contains(findOn))
{
    Console.WriteLine("Extra notes: Blew up a lightbulb");
 
}
else if (lights.Contains(findOff))
{
    Console.WriteLine("Extra notes: flicked light switch off as soon as it was turned on");
  
}

Console.WriteLine("Evidence's found: Spirit box, Ghost Writing, Ghost Orbs ");
Console.WriteLine("Ghost type: The Mare");