using System;


// System.Console.Write("Birinchi sonni kiriting: ");
// string a = System.Console.ReadLine();
// int firstNumber = System.Convert.ToInt32(a);
// System.Console.Write("Ikkinchi sonni kiriting: ");
// string b = System.Console.ReadLine();
// int secondNumber = System.Convert.ToInt32(b);

// //   + - * /
// System.Console.WriteLine($"Adding(Qo'shish) {firstNumber + secondNumber}");
// System.Console.WriteLine($"Substracting(Ayirish) {firstNumber - secondNumber}");
// System.Console.WriteLine($"Divide(Bo'lish) {firstNumber / secondNumber}");
// System.Console.WriteLine($"Multiplying(Ko'paytirish) {firstNumber * secondNumber}");

// // % qoldiqni chiqaradi

// System.Console.WriteLine($"Residual(Qoldiq) {firstNumber % secondNumber}");



System.Console.Write("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"1st number is greater than 2nd number: {firstNumber > secondNumber}");
System.Console.WriteLine($"1st number is greater than or equal to 2nd number: {firstNumber >= secondNumber}");
System.Console.WriteLine($"1st number is less than 2nd number: {firstNumber < secondNumber}");
System.Console.WriteLine($"1st number is less than or equal to 2nd number: {firstNumber <= secondNumber}");
System.Console.WriteLine($"Numbers are equal: {firstNumber == secondNumber}");
System.Console.WriteLine($"Numbers are not equal: {firstNumber != secondNumber}");

