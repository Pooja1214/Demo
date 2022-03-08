// See https://aka.ms/new-console-template for more information
string l1 = "my name is pooja";
string l2 = "I am from latur";
string l3 = "I am from latur";
if (String.Equals(l1, l2))
    Console.WriteLine($"{l1} and {l2} are equal");
else
    Console.WriteLine($"{l1} and {l2} are not equal");
if (String.Equals(l2, l3))
    Console.WriteLine($"{l2} and {l3} are equal");
else
    Console.WriteLine($"{l2} and {l3} are not equal");
