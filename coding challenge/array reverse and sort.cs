//Array reverse and Sort

string[] pallets = { "T30", "A43", "B52", "R87" };
Console.WriteLine("Sorted ....");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Reverse ....");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}