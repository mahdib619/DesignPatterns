//this design pattern is used to implement undo action
using System;
using P01_Memento;

var editor = new Editor { Content = "this is init value", Title = "file.txt" };
var history = new History();

while (true)
{
    ShowMenu();
    var input = Console.ReadLine();

    switch (input)
    {
        case null:
            Console.WriteLine("Input empty!");
            Console.ReadKey();
            break;
        case "u":
            if (history.States.Count > 0)
            {
                history.States.Pop().Restore();
                Console.WriteLine($"Title: {editor.Title}");
                Console.WriteLine($"Content: {editor.Content}");
                Console.ReadKey();
            }
            break;
        case "c":
            Console.WriteLine($"Title: {editor.Title}");
            Console.WriteLine($"Content: {editor.Content}");
            Console.ReadKey();
            break;
        default:
            try
            {
                var split = input.Split('=');
                var option = split[0];
                var value = split[1];

                switch (option)
                {
                    case "c":
                        history.States.Push(editor.CreateState());
                        editor.Content = value;
                        break;
                    case "t":
                        history.States.Push(editor.CreateState());
                        editor.Title = value;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            catch (Exception e) when (e is IndexOutOfRangeException or ArgumentException)
            {
                Console.WriteLine("Invalid input!\nPress any key to continue...");
                Console.ReadKey();
            }
            break;
    }

    ShowMenu();
}

void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("t=<title> to set title\nc=<content> to set content\nc to get current values\nu to undo");
    Console.WriteLine($"------------------------------------\n{editor.Title}\n------------------------------------");
}