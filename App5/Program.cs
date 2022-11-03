System.Console.WriteLine("Start");
// try + tab
try
{
    string txt = System.IO.File.ReadAllText("C:\\prosaintrocs\\test.txt");
    System.Console.WriteLine(txt);
}
catch (System.Exception ex)
{
    System.Console.WriteLine("Fejl " + ex.Message);
}
System.Console.WriteLine("Slut");