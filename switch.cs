using System;

string peoplesName = Console.ReadLine();

switch(peoplesName)
{
    case "Jahongir":
    Console.WriteLine("men's name");
    break;
    case "Sara":
    Console.WriteLine("girl's name");
    break;
    default:
    Console.WriteLine("programm don't know this name");
    break;
}