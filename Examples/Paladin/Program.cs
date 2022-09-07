int health = 55;
int mana = 9;
int coins = 11;

string[] result = new string[11];

int bonusHealthValue = 6;
int bonusManaValue = 7;
int bonusCoinsValue = 8;

int maximumPar = 0;
int middlePar = 0;
int bottomPar = 0;
string max = string.Empty;
string mid = string.Empty;
string bot = string.Empty;

int openCounter = 11;

for (int i = 0; i < openCounter; i++)
{
    Console.WriteLine($"---ITERATION STARTED {i}---");
    
    if(health > mana && health > coins)
    {
        maximumPar = health;
        max = "Health";
        if (mana > coins) 
        {
            middlePar = mana;
            mid = "Mana";
            bottomPar = coins;
            bot = "Coins";
        }
        else
        {
            middlePar = coins;
            mid = "Coins";
            bottomPar = mana;
            bot =  "Mana";
        }
    } 
    if(mana > health && mana > coins)
    {
        maximumPar = mana;
        max = "Mana";
        if (health > coins) 
        {
            middlePar = health;
            mid = "Health";
            bottomPar = coins;
            bot =  "Coins";
        }
        else
        {
            middlePar = coins;
            mid = "Coins";
            bottomPar = health;
            bot =  "Health";
        }
    } 
    if(coins > health  && coins > mana)
    {
        maximumPar = coins;
        max = "Coins";

        if (health > mana) 
        {
            middlePar = health;
            mid = "Health";
            bottomPar = mana;
            bot = "Mana";
        }
        else
        {
            middlePar = mana;
            mid = "Mana";
            bottomPar = health;
            bot = "Health";
        }
    }

    Console.WriteLine($"Max is {max} = {maximumPar} Mid is {mid} = {middlePar} Bot is {bot} = {bottomPar} ");

    if (maximumPar > middlePar + 20)
    {
        if(mid == "Health") 
        {
            health += bonusHealthValue; 
            result[i] += "h";
        }
        if(mid == "Mana")
        {
            mana   += bonusManaValue;
            result[i] += "m";
        }
            
             if(mid  == "Coins")
        {
            coins   += bonusCoinsValue;
            result[i] += "c";
        }
    }
    else if (maximumPar == middlePar + 20 || maximumPar < middlePar + 20)
    {
        if(max == "Health") 
        {
            health += bonusHealthValue; 
            result[i] += "h";
        }
        if(max == "Mana")
        {
            mana   += bonusManaValue;
            result[i] += "m";
        }
            
        if(max  == "Coins")
        {
            coins   += bonusCoinsValue;
            result[i] += "c";
        }
    }
    

    Console.WriteLine($"---------------------------------");
}

Console.WriteLine($"{health} {mana} {coins}");
Console.WriteLine(string.Join(",", result));