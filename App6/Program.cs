


string navn = "Mikkel";
int alder = 19;

Person p = new Person();
p.Navn = "Michell";
p.Alder = 19;
// Serialisering / Deserialisering

Terning t = new Terning();
t.Skriv();

for (int i = 0; i < 10; i++)
{
    t.Ryst();
    t.Skriv();

}

System.Console.WriteLine();
LudoTerning l = new LudoTerning();
l.Skriv();
System.Console.WriteLine(l.ErStjerne());



class Person
{
    // Felter
    public string Navn;
    public int Alder;
}


// Abstraktion
class Terning
{
    // Egenskab / property (Indkapsling)
    public int Værdi { get; set; }

    public void Ryst()
    {
        int t = new Random().Next(1, 7);
        this.Værdi = t;
    }

    // Constructor
    public Terning()
    {
        this.Ryst();
    }

    public void Skriv()
    {
        System.Console.WriteLine(this.Værdi);
    }

}

// Nedarvning
class LudoTerning : Terning
{
    public bool ErStjerne()
    {
        return this.Værdi == 3;
    }
}

