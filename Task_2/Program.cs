// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

int b = 0;
int c = 0;
void TwoNumber(int a)
{
    if (b == a % 10){
        Console.WriteLine(b);
    }
    if (c == a / 10){
        Console.WriteLine(c); }
    else
    {
        Console.WriteLine ("Число не трехзначное");
    }
}
Console.WriteLine(TwoNumber(new Random().Next(100, 1000)));