using System;

Console.WriteLine("Hello, World!");
Console.WriteLine();

// Data Types
double d = 1005.66365;
int i = 6365;
long l = 243412;
char c = 'A';

Console.WriteLine("Double : " + d);
Console.WriteLine("Integer : " + i);
Console.WriteLine("Long : " + l);
Console.WriteLine("Character : " + c);

Console.WriteLine();

// Arithmetic Operator
int a = 10;
int b = 5;
Console.WriteLine("Addition = " + (a + b));

Console.WriteLine();

// Assignment Operator
int x = 10;
x = x + 5;
Console.WriteLine("Assignment = " + x);

Console.WriteLine();

// Relational Operator
Console.WriteLine("Comparison = " + (a > b));

Console.WriteLine();

// Logical Operator
bool p = true;
bool q = false;
Console.WriteLine("Logical = " + (p || q));

Console.WriteLine();

// Increment Operator
int num = 5;
num++;
Console.WriteLine("Increment = " + num);

// Decrement Operator
num--;
Console.WriteLine("Decrement = " + num);

Console.WriteLine();

// Bitwise Operator
int m = 5;
int n = 3;
Console.WriteLine("Bitwise AND = " + (m & n));

Console.WriteLine();

// Conditional (Ternary) Operator
int age = 20;
string result = (age >= 18) ? "Adult" : "Minor";
Console.WriteLine("Result = " + result);