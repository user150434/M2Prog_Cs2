using System;

public class Class1
{
	public Class1()
	{

        internal class Formulier
    {
        public string Naam { get; set; }
        public string Status { get; set; }
        public DateTime IngevuldOp { get; set; }

        public Formulier(string naam, string status, DateTime ingevuldOp)
        {
            Naam = naam;
            Status = status;
            IngevuldOp = ingevuldOp;
            Array.Resize(ref prijzen, prijzen.Length + 1);
            prijzen[prijzen.Length - 1] = 40.0; // Nieuwe prijs toevoegen
            Array.Resize(ref artikelen, artikelen.Length + 1);
            artikelen[artikelen.Length - 1] = "Markeerstift"; // Nieuwe artikel toevoegen
            string[] characters = new string[]
            {
    "Pac-Man", "Samus", "Crash Bandicoot", "Spyro the Dragon", "Donkey Kong",
    "Mario", "Luigi", "Astro", "Solid Snake", "Master Chief", "Kratos", "Sonic the Hedgehog", "Link"
            };

            List<string> characterList = new List<string>(characters);
            characterList.Add("Mega Man"); // Voeg een nieuw character toe
            for (int i = 0; i < characters.Length; i++)
            {
                characterList.Add(characters[i]);
            }
            // Met for
            for (int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine(characterList[i]);
            }

            // Met foreach
            foreach (var character in characterList)
            {
                Console.WriteLine(character);
            }
            List<double> reviews = new List<double> { 342.97, 250.50, 300.30 };
            reviews.Remove(342.97); // Verwijder een specifiek getal
            reviews.RemoveAt(0);    // Verwijder het getal op index 0
internal class Pickup
        {
            public string Naam { get; set; }
            public bool IsOpgepakt { get; set; }

            public Pickup(string naam)
            {
                Naam = naam;
                IsOpgepakt = false;
            }
        }

        List<Pickup> pickups = new List<Pickup>
{
    new Pickup("GezondheidsPakket"),
    new Pickup("Munitie"),
    new Pickup("Sleutels")
};

        // Voeg pickups toe
        pickups.Add(new Pickup("Medicijn"));
for (int i = pickups.Count - 1; i >= 0; i--)
{
    if (!pickups[i].IsOpgepakt)
    {
        pickups[i].IsOpgepakt = true;
        Console.WriteLine($"Pickup {pickups[i].Naam} opgepakt!");
    }
}
List<Mob> mobs = new List<Mob>
{
    new Mob("Goblin", 100),
    new Mob("Ork", 50),
    new Mob("Troll", 0)
};

var defeatedMobs = mobs.Where(mob => mob.IsDead).ToList();

foreach (var mob in defeatedMobs)
{
    Console.WriteLine($"Verslagen mob: {mob.Name}");
}
internal class Mob
{
    public string Name { get; set; }
    public int HP { get; set; }
    public bool IsDead { get; set; }

    public Mob(string name, int hp)
    {
        Name = name;
        HP = hp;
        IsDead = false;
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            IsDead = true;
            Console.WriteLine($"{Name} is verslagen!");
        }
    }
}
Random random = new Random();
for (int i = 0; i < 100; i++)
{
    foreach (var mob in mobs)
    {
        int damage = random.Next(1, 10);
        if (damage < 3)
        {
            mob.TakeDamage(damage);
        }
    }
}

        }
for (int i = 0; i<prijzen.Length; i++)
{
    Console.WriteLine($"Prijs: {prijzen[i]}, Artikel: {artikelen[i]}");
}

}

}
}
