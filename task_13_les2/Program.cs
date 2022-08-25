// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");

int inNum = Convert.ToInt32(Console.ReadLine());
string inNumtext = Convert.ToString(inNum);

if (inNumtext.Length > 2){
  Console.WriteLine(inNumtext[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}