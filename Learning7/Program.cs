Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");

wizard01.CastSpell();

Wizard wizard02 = new Wizard("Glindolf Merlinson", "Abracadabra");

wizard02.CastSpell();

Console.WriteLine(Wizard.Count);

class Wizard
{
    public string name;
    public string favouriteSpell;
    private int spellslots;
    private float experience;
    
    public static int Count;
    
    public Wizard(string _name, string _favouriteSpell)
    {
        name = _name;
        favouriteSpell = _favouriteSpell;
        spellslots = 2;
        experience = 0f;

        Count++;
    }
    public void CastSpell()
    {
        if (spellslots > 0)
        {
            Console.WriteLine(name + " casts " + favouriteSpell);
            spellslots--;
            experience += 0.3f;
        }
        else
        {
            Console.WriteLine(name + " is out of spell slots.");
        }
    }
    public void Meditate()
    {
        Console.WriteLine(name + " meditates to regain spell slots.");
        spellslots = 2;
    } 
}