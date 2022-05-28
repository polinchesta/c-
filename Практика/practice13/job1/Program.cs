Operation operation = FuncOne;
double result = operation(2);
Console.WriteLine(result);

operation = FuncTwo;
result = operation(2);
Console.WriteLine(result);

operation = FuncThree;
result = operation(2);
Console.WriteLine(result);

PrintMessage(operation);

double FuncOne(int x) => Math.Pow(x, 1);
double FuncTwo(int x) => Math.Sin(x);
double FuncThree(int x) => Math.Cos(x);

void PrintMessage(Operation someMessage) => Console.WriteLine(someMessage(2));

delegate double Operation(int x);