using static System.Console;

WriteLine("Hello, World!");
ShowArgs(args);

void ShowArgs(string[] args)
{
    foreach (var s in args)
    {
        WriteLine(s);
    }
}
