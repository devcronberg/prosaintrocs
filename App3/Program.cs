

// Ctrl + F5 = afvikling uden fejlfinding
// F5 = med fejlfinding
// F9 breakppoint
// F10 = hop videre i kode

System.Console.WriteLine("Start");  // cw + tab
int a = 10;
int b = 1;
if (a < 10 || b == 1)
    System.Console.WriteLine("a<10");
else
{
    System.Console.WriteLine("a>=10");
}

// for (find ikon firkant) + tab
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine(i);
}

DateTime d = DateTime.Now.AddSeconds(1);
do
{
    System.Console.WriteLine("*");
} while (DateTime.Now < d);

// Ctrl + K + C (U)

// int c = 1;
// System.Console.WriteLine(c);
// c++;
// System.Console.WriteLine(c);
// c++;
// System.Console.WriteLine(c);


System.Console.WriteLine("Slut");