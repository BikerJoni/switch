using System;
using System.Security.Cryptography;

// switch -> pattern matching
string inputName = Console.ReadLine();
string phonesPrice = inputName switch
{
    "iphone 15 pro" => "1200$",
    "samsung S24" => "900$",
    _ => "unfortunatly this kind of phone is over",
};
Console.WriteLine(phonesPrice);