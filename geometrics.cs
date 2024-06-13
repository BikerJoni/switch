using System;
// Uchburchak turini aniqlash formulasi

int kattaBurchagi = Console.ReadLine();
switch(kattaBurchagi)
{
    case (kattaBurchagi is > 0 and < 90):
    Console.WriteLine("O'tkir burchaklik uchburchak");
    break;
    case (kattaBurchagi is 90 ):
    Console.WriteLine("to'g'ri burchaklik uchburchak");
    break;
    default:
    Console.WriteLine("O'tmas burchaklik uchburchak");
    break;
}
