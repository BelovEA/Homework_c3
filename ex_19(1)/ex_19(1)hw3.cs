//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом
//14212 -> нет 12821 -> да 23432 -> да
Console.Write("Введите пятизначное целое число, проверим является ли число палиндромом, если является - да, если нет - нет ");
int n;
while(!int.TryParse(Console.ReadLine(), out n))
{
    Console.Write("Введен неверный параметр, введите целое пятизначное число: ");
}
int Palindrome(int n)
{
int first_number = n / 10000;
int second_number = (n / 1000) % 10;
int third_number = (n / 100) % 10;
int fourth_number = (n / 10) % 10;
int fifth_number = (n % 10);
    if (first_number == fifth_number && second_number == fourth_number)
    
        return 1;
    
    else
    
        return 2;
}

var result = Palindrome(n);

if (result == 1)
{
    Console.WriteLine("да");
}
if (result == 2)
{
    Console.WriteLine("нет");
}