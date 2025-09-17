Console.WriteLine("what is your name?");
Console.WriteLine("");

String Name = Console.ReadLine();
string yourName = Name;

Console.WriteLine("");
Console.WriteLine("how much gold do you have?");
Console.WriteLine("");

int Gold = int.Parse(Console.ReadLine());
int yourGold = Gold;   

Console.WriteLine("a bronze sword costs 15 gold");

if (yourGold < 15)
{
    Console.WriteLine($"uh oh! sorry {yourName}, you dont have enough gold!");
}

else 
{
    yourGold -= 15;
    Console.WriteLine("you buy the bronze sword!");
    Console.WriteLine($"its a nice sword, {yourName}, you now only have {yourGold} gold left!");
}