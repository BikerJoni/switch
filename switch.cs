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

string odamlarIsmi;
Console.Write("isimni kiriting: ");
odamlarIsmi = Console.ReadLine();
 if (odamlarIsmi is "Jahongir");
 {
    Console.WriteLine("meni ismim");
 }
 else if (odamlarIsmi is"Elbek");
 {
    Console.WriteLine("Ustoz");
 }
 else 
 {
    Console.WriteLine("bu odamni tanimiman");
 }