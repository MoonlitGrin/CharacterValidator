// Variables.
int strength = 0;
int intelligence = 0;

int strengthBonus = 0;
int intelligenceBonus = 0;
// Introduction & Instructions.
Console.WriteLine("Hello, please submit a number between 1-20 for your character's strength.");
strength = Convert.ToInt32(Console.ReadLine());

// Stats (while statements).
while (strength < 1 || strength > 20) 
{
    Console.WriteLine("An error has occured, please re-sumbit your strength and ensure it is between 1-20.");
    strength = Convert.ToInt32(Console.ReadLine());
}
strengthBonus = (strength - 10) / 2;
Console.WriteLine("Strength Bonus: " + strengthBonus);


Console.WriteLine("Please submit a number between 1-20 for your character's intelligence.");
intelligence = Convert.ToInt32(Console.ReadLine());

while (intelligence < 1 || intelligence > 20)
{
    Console.WriteLine("An error has occured, please re-submit your intelligence and ensure it is between 1-20.");
    intelligence = Convert.ToInt32(Console.ReadLine());
}
intelligenceBonus = (intelligence - 10) / 2;
Console.WriteLine("Intelligence Bonus: " + intelligenceBonus);

// Calculations.
if (strengthBonus > 1)
    Console.WriteLine("Your character is qualified to be a Warrior!");

if (intelligenceBonus > 1)
    Console.WriteLine("Your character is qualified to be a Mage!");