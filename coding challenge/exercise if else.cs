//Exercise: If else

Random random = new Random();
int daysUntilExpiration = random.Next(15);
int discountPercentage = 2;

if (daysUntilExpiration == 3)
{
    discountPercentage = 20;
}
if (daysUntilExpiration <= 8)
{
    discountPercentage = 10;
}
if (daysUntilExpiration < 3)
{
    Console.WriteLine("Your subscription has expired!");
}

else if (daysUntilExpiration == 3)
{
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save" + discountPercentage + " %!");
}
else if (daysUntilExpiration <= 8)
{
    Console.WriteLine("Your subscription expires in:" + daysUntilExpiration + " days.");
    Console.WriteLine("Renew now and save" + discountPercentage + " %!");

}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine("Your subscription expires in:" + daysUntilExpiration + " days.");

    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

