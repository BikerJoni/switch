using System;

int solderAge;
Console.Write("Enter the age");
string candidateAge = Console.ReadLine();
solderAge = Convert.ToInt32(candidateAge);
bool solder = solderAge is > 17 and <28;

string natija = solder

    ? "armiyaga yaroqli"
    : "armiyaga bormaydi";
Console.WriteLine(natija);
