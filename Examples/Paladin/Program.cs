
// 26
int Paladin_health = 450;
int Paladin_damage = 0;
int Orc_damage = 5;
// int Orc_health = 100;
int Orc_quantity = 33;
int counter = 1;
int Rounds = 0;

while (Paladin_health > 0 && Orc_quantity > 0) 
{
    if (counter != 4) 
    {
        Paladin_health = Paladin_health - (Orc_damage);
        Console.WriteLine("Paladin's HEALTH after taking damage");
        Console.WriteLine(Paladin_health);
        Console.WriteLine("----------------");
        Paladin_damage += 8;
        Console.WriteLine("DAMAGE DONE TO ORC:");
        Console.WriteLine(Paladin_damage);
        Console.WriteLine("--------------------");
        if (Paladin_damage >= 100)
        {
            Orc_quantity -= 1;
            Paladin_damage = 0;
            Console.WriteLine("Orc died, Total number of Orcs left...");
            Console.WriteLine(Orc_quantity);
        }
    }

    else if (counter % 4 == 0) 
    {
        Paladin_health += 12;
        counter = 0;
        Console.WriteLine("Iteration 4 HEALING, Total health is...");
        Console.WriteLine(Paladin_health);
        Console.WriteLine("-----------------------------------------");
    }

    counter++;
    Rounds++;
}

Console.WriteLine("Если Паладин убил всех орков, то его оставшееся здоровье составляет...");
Console.WriteLine(Paladin_health);
Console.WriteLine("Если Паладин погиб, то оставшееся количество орков составляет...");
Console.WriteLine(Orc_quantity);
Console.WriteLine(Rounds);