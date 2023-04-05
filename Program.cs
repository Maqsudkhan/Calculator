using System;

string password = "";
do
{
    System.Console.Write("Enter you password: ");
    password = Console.ReadLine();
}
while(password != "Maqsudkhan");


System.Console.Write("Birinchi sonni kiriting: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ikkinchi sonni kiriting: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    System.Console.WriteLine("The 1st is greater than the 2nd!");
}
else if (a==b)
{
    System.Console.WriteLine("The numbers equal!");
}
else
{
    System.Console.WriteLine("The 1st is less than the 2nd!");
}



// //   + - * /
// System.Console.WriteLine($"Adding(Qo'shish) {firstNumber + secondNumber}");
// System.Console.WriteLine($"Substracting(Ayirish) {firstNumber - secondNumber}");
// System.Console.WriteLine($"Divide(Bo'lish) {firstNumber / secondNumber}");
// System.Console.WriteLine($"Multiplying(Ko'paytirish) {firstNumber * secondNumber}");

// // % qoldiqni chiqaradi

// System.Console.WriteLine($"Residual(Qoldiq) {firstNumber % secondNumber}");



// System.Console.Write("Type 1st number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Type 2nd number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"1st number is greater than 2nd number: {firstNumber > secondNumber}");
// System.Console.WriteLine($"1st number is greater than or equal to 2nd number: {firstNumber >= secondNumber}");
// System.Console.WriteLine($"1st number is less than 2nd number: {firstNumber < secondNumber}");
// System.Console.WriteLine($"1st number is less than or equal to 2nd number: {firstNumber <= secondNumber}");
// System.Console.WriteLine($"Numbers are equal: {firstNumber == secondNumber}");
// System.Console.WriteLine($"Numbers are not equal: {firstNumber != secondNumber}");


// // for va foreach yordamida 1 dan 10 gacha bo'lgan sonlarni  ekranga chiqarish dasturi.

// for(int i = 1; i <= 10; i++)
// {
//     System.Console.WriteLine(i);
// }


// int[] number = {1,2,3,4,5,6,7,8,9,10,11,12};
// foreach(int num in number)
// {
//     System.Console.WriteLine(num);
// }


// Switch
System.Console.Write("Enter operation (+,/,*,-,%) >>> ");
string operation = Console.ReadLine();
switch(operation)
{
    case "+":
        System.Console.WriteLine($"{a}+{b}={a+b}");
    break;
    case "-":
        System.Console.WriteLine($"{a}-{b}={a-b}");
    break; 
    case "*":
        System.Console.WriteLine($"{a}x{b}={a*b}");
    break;
    case "/":
        System.Console.WriteLine($"{a}:{b}={a/b}");
    break;
    case "%":
        System.Console.WriteLine($"{a}%{b}={a%b} (qoldiq)");
    break;
    default:
        System.Console.WriteLine("Operation Not Found!");
    break;
}


