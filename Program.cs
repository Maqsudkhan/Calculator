using System;

System.Console.Write("Birinchi sonni kiriting: ");
string a = System.Console.ReadLine();
int firstNumber = System.Convert.ToInt32(a);
System.Console.Write("Ikkinchi sonni kiriting: ");
string b = System.Console.ReadLine();
int secondNumber = System.Convert.ToInt32(b);

//   + - * /
System.Console.WriteLine($"Adding(Qo'shish) {firstNumber + secondNumber}");
System.Console.WriteLine($"Substracting(Ayirish) {firstNumber - secondNumber}");
System.Console.WriteLine($"Divide(Bo'lish) {firstNumber / secondNumber}");
System.Console.WriteLine($"Multiplying(Ko'paytirish) {firstNumber * secondNumber}");

// % qoldiqni chiqaradi

System.Console.WriteLine($"Residual(Qoldiq) {firstNumber % secondNumber}");