//challenge rool dice

Random dice = new Random();

int rool1 = dice.Next(1,7);
int rool2 = dice.Next(1,7);
int rool3 = dice.Next(1,7);

int total = rool1 + rool2 + rool3;

Console.WriteLine($"Dice roll: {rool1} + {rool2} + {rool3} = {total}");

if ((rool1 == rool2) || (rool1 == rool3) || (rool2 == rool3))
{
    if ((rool1 == rool2) && (rool2 == rool3))
    {
        total += 6;
        Console.WriteLine("You rolled triples! +6 bonus to total!");
    }
    else
    {
        total += 2;
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
    }
    
    Console.WriteLine($"Your total including the bonus: {total}");
}



if (total >= 16)
{
    Console.WriteLine("You Win a new car");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

