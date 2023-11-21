using static Classc;

MyDelegate del1 = ClassA.MethodA;
MyDelegate del2 = ClassB.MethodB;

MyDelegate del = del1 + del2;
Console.WriteLine(del()); //Ekranga 200 chiqadi

Console.ReadKey();
class Classc
{
    public delegate int MyDelegate();
}
class ClassA
{
    public static int MethodA()
    {
        int a = 1;
        // Console.WriteLine(a);
        return a;
    }
}
class ClassB
{
    public static int MethodB()
    {
        int a = 1;
        return a;
    }
}