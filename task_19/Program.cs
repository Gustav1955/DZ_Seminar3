/*Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите числo =>  ");
int number = Convert.ToInt32(Console.ReadLine());

string r = number.ToString();
char[] ar = r.ToCharArray();
Array.Reverse(ar);
r = new String(ar);
int rev = Convert.ToInt32(r);

if (number == rev) Console.WriteLine("число является полиндромом");
else Console.WriteLine("число НЕ является полиндромом");


