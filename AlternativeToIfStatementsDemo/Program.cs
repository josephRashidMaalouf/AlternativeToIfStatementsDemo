// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Pick a method: A, B, C or D");
var methodChoice = Console.ReadLine().ToUpper();


//If-statements
if (methodChoice == "A")
{
    MethodA();
}
else if (methodChoice == "B")
{
    MethodB();
}
else if (methodChoice == "C")
{
    MethodC();
}
else if (methodChoice == "D")
{
    MethodD();
}
else
{
    InvalidInput();
}

//Switch statement

//Classical style
switch (methodChoice)
{
    case "A":
        MethodA();
        break;
    case "B":
        MethodB();
        break;
    case "C":
        MethodC();
        break;
    case "D":
        MethodD();
        break;
    default:
        InvalidInput();
        break;
}

//short hand style

Action method = methodChoice switch
{
    "A" => MethodA,
    "B" => MethodB,
    "C" => MethodC,
    "D" => MethodD,
    _ => InvalidInput
};

method();

//Dictionary

Dictionary<string, Action> methods = new()
{
    { "A", MethodA },
    { "B", MethodB },
    { "C", MethodC },
    { "D", MethodD }
};

if (methods.ContainsKey(methodChoice))
{
    methods[methodChoice]();
}
else
{
    InvalidInput();
}





void MethodA()
{
    Console.WriteLine("This is method A");
}

void MethodB()
{
    Console.WriteLine("This is method B");
}

void MethodC()
{
    Console.WriteLine("This is method C");
}

void MethodD()
{
    Console.WriteLine("This is method D");
}

void InvalidInput()
{
    Console.WriteLine("Invalid method");
}