﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число");

int parity = Convert.ToInt32(Console.ReadLine()); 

    if (parity % 2 == 1 ){
     Console.Write("нет");
 }
 else
 {
  Console.Write("да");
 }