
// variabler

// heltal, reeele, string, datetime, bool (sand/false)

//int tal1 = 0;           // heltal
System.Int32 tal1 = new System.Int32();
tal1 = 0;
double tal2 = 100.55;   // reelt tal

tal1 = tal1 + 1;
tal1++;

tal2 = tal2 * 2;

Console.WriteLine("Tal:");
Console.WriteLine(tal1);
Console.WriteLine(tal2);

string tekst1 = "Min tekst";
tekst1 = tekst1 + "***";
System.Console.WriteLine(tekst1);   // cw + tab
System.Console.WriteLine(tekst1.Substring(4, 2));
System.Console.WriteLine(tekst1.ToUpper());


DateTime r = new DateTime(2022, 5, 28);
System.Console.WriteLine("Dato");
System.Console.WriteLine(r);
r = r.AddDays(15);
System.Console.WriteLine(r);

bool b = true;
System.Console.WriteLine("Sand/Falsk");
System.Console.WriteLine(b);