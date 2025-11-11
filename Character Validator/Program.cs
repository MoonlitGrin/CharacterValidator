// Variables.
int strength = 0;
int intelligence = 0;

int bonusStrength = 0;
int bonusIntelligence = 0;
// Introduction & Instructions.
Console.WriteLine("Hello, please submit a number between 1-20 for your character's strength.");
strength = Convert.ToInt32(Console.ReadLine());

// Stats (while statements).
while (strength < 1 || strength > 20) 
{
    Console.WriteLine("An error has occured, please re-sumbit your strength and ensure it is between 1-20.");
    strength = Convert.ToInt32(Console.ReadLine());
}
bonusStrength = (strength - 10) / 2;
Console.WriteLine("Strength Bonus: " + bonusStrength);


Console.WriteLine("Please submit a number between 1-20 for your character's intelligence.");
intelligence = Convert.ToInt32(Console.ReadLine());

while (intelligence < 1 || intelligence > 20)
{
    Console.WriteLine("An error has occured, please re-submit your intelligence and ensure it is between 1-20.");
    intelligence = Convert.ToInt32(Console.ReadLine());
}
bonusIntelligence = (intelligence - 10) / 2;
Console.WriteLine("Intelligence Bonus: " + bonusIntelligence);
// Calculations.
if (bonusStrength > 1)
    Console.WriteLine("Your character is qualified to be a Warrior!");

if (bonusIntelligence > 1)
    Console.WriteLine("Your character is qualified to be a Mage!");