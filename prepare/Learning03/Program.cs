using System;

Console.WriteLine("Hello Wolrd");
Fraction one = new Fraction();

Fraction one2 = new Fraction(6);

Fraction one3 = new Fraction(6, 7);

// Decimal
Console.WriteLine(one.GetDecimalValue());
Console.WriteLine(one2.GetDecimalValue());
Console.WriteLine(one3.GetDecimalValue());
// fraction
Console.WriteLine(one.GetFractionNotation());
Console.WriteLine(one2.GetFractionNotation());
Console.WriteLine(one3.GetFractionNotation());