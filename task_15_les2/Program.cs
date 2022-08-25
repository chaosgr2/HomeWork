// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру");



int innum = Convert.ToInt32(Console.ReadLine());

void checkDay (int innum){

if (innum == 6)
{
    Console.WriteLine("Выходной");
}
else if (innum == 7)
{
    Console.WriteLine("Выходной");
}
else if (innum < 1)
{
    Console.WriteLine("Не является днем недели");
}
else if (innum > 7)
{
    Console.WriteLine("Не является днем недели");
}
else
{
    Console.WriteLine("Будний день");
}
}

checkDay(innum);