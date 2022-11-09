// See https://aka.ms/new-console-template for more information





while (true)

{
    Console.WriteLine("Select an Option from [c, o, d, e]");
    var input = Console.ReadLine();
    Console.WriteLine(" ");

    if (input.ToUpper() == "C")
    {
        Console.WriteLine("C# books");
        break;
    }
    else if (input.ToUpper() == "O")
    {
        Console.WriteLine(".NET core books");
        break;
    }
    else if (input.ToUpper() == "D")
    {
        Console.WriteLine("clean coding books");
        break;
    }
    else if (input.ToUpper() == "E")
    {
        Console.WriteLine("EFCore books");
        break;
    }
    else
    {
        Console.WriteLine("Try Again");
       
    };
}


