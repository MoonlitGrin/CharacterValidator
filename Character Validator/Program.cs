// Global Variables.
using System.Net.Security;

int strength = 0;
int intelligence = 0;

int strengthBonus = 0;
int intelligenceBonus = 0;

// Functions.
int GetStatValue(string statName)
{
    int statValue = 0;
    Console.WriteLine("Please enter the stats for " + statName);
    statValue = Convert.ToInt32(Console.ReadLine());
    while (IsStatValid(statValue) == false)
    {
        Console.WriteLine("The following is invalid, please re-enter.");
        statValue = Convert.ToInt32(Console.ReadLine());
    }
    return statValue;
}
bool IsStatValid(int statValue)
{
    bool valid = true;
    if (statValue < 1 || statValue > 20)
    {
        valid = false;
    }
    return valid;
}
int CalculateStatBonus(int statValue)
{
    int statBonus = 0;
    statBonus = (statValue - 10) / 2;
    return statBonus;
}

// Global Code.
strength = GetStatValue("strength");
intelligence = GetStatValue("intelligence");

// Calculations.
strengthBonus = CalculateStatBonus(strength);
Console.WriteLine("The stat bonus for strength is " + strengthBonus);
intelligenceBonus = CalculateStatBonus(intelligence);
Console.WriteLine("The stat bonus for intelligence is " + intelligenceBonus);

// Qualification.
if (strengthBonus >= 1)
    Console.WriteLine("You qualify to be a warrior.");
if (intelligenceBonus >= 1)
    Console.WriteLine("You qualify to be a mage.");