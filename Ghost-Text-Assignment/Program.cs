Console.WriteLine("Narrator: Boo! Youre a ghost in a haunted mansion!");
Console.WriteLine("Narrator: Luckily, youre the one haunting it");
Console.WriteLine("");
Console.WriteLine("Narrator: Its not a mansion if you dont have your favourite room!");
Console.WriteLine("Narrator: by the way, what is your favourite room in this mansion you call home?");
Console.WriteLine("");
string room = Console.ReadLine();

string favouriteRoom = room;
Console.WriteLine("");
Console.WriteLine($"Narrator: Wow! The {favouriteRoom} is my favourite room too!");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Narrator: You hear something outside... it sounds like a vehicle");
Console.WriteLine("Narrator: in through the door bursts 4 ghost hunters!");
Console.WriteLine("Narrator: one of them finds the ouiji board you left out, he asks");
Console.WriteLine("Hunter: What year did you die?");
Console.WriteLine("");

//finds out how many years ago you died
int death = int.Parse(Console.ReadLine());
int currentYear = DateTime.Now.Year;
int died = currentYear - death;
Console.WriteLine("");
Console.WriteLine($"Hunter: Wow this ghost died {died} years ago!");
Console.WriteLine("");


Console.WriteLine("Narrator: You see the hutners scramble around a bit more, before one pulls out a small radio like device");
Console.WriteLine("Narrator: one of the hunters speak into the radio and say");
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
    Console.WriteLine($"Hunter: {hurt} was utter nonesense, this ghost seems a bit strange...");
}

Console.WriteLine("Narrator: You hear a flick come from the basement, followed by");
Console.WriteLine("Hunter: Generators on!");
Console.WriteLine("Narrator: You see one of the hunters flick a light switch on, and the blaring lights come to life");
Console.WriteLine("Narrator: do you wish to leave the light on, or turn it back off?");
Console.WriteLine("");

string lights = Console.ReadLine();

if (lights == "on" )
{
    Console.WriteLine("Narrator: You leave the lights on, but start to get this strange feeling");
    Console.WriteLine("Narrator: Your head starts pounding, and you start getting dizzy");
    Console.WriteLine("Narrator: You snap out of it, and as you do the light bulbs in the room explode, leaving you in darkness");
}

else if (lights == "off" )
{
    Console.WriteLine("Narrator: you rush to the lights as fast as you can and switch them back off");
}