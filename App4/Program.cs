
Test1();
Test1();
Test1();

Test2(5);
Test2(50);

int res = Test3();
System.Console.WriteLine(res);

int res2 = LægSammen(5, 5);
System.Console.WriteLine(res2);

bool res3 = CheckTal(5);
System.Console.WriteLine(res3);
res3 = CheckTal(15);
System.Console.WriteLine(res3);


void Test1()
{
    System.Console.WriteLine(" * Test1");
}

void Test2(int a)
{
    System.Console.WriteLine(" * Test2 med " + a);
}

int Test3()
{
    return 3;
}

int LægSammen(int a, int b)
{
    return a + b;
}


bool CheckTal(int a)
{
    bool r = a < 10;
    return r;
}