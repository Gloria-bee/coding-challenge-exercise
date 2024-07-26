//Overiding

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(90);
int roll3 = dice.Next(30, 90);
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
