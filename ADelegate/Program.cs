using ADelegate;
using static ADelegate.A_SimpleDelegete;

WithParameters withParameters = new WithParameters(Methods.Sum);
withParameters(1, 2);

WithParameters anonymousMethod = (int a, int b) => Math.Min(a,b);
var natija = anonymousMethod.Invoke(5, 6);
Console.WriteLine("Max: " + natija);

