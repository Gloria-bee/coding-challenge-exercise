//Array .clear

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 1);
if (pallets[0] != null)
{
    Console.WriteLine($"After: {pallets[0].ToLower()}");
}

Console.WriteLine($"Clearing 1 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
