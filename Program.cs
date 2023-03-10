/*int CutNumber(int num)
{
  int hundreds = num / 100;
  int units = num % 10;

  int result =  hundreds * 10 + units;
  return result;
}
int randomNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randomNumber);
Console.WriteLine($"New version of {randomNumber} us {newNumber}");
*/
/*
1.Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
2.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b
3.Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/
//1.
/*
int GetMaxNumber(int num)
{
  int num1 = num / 10;
  int num2 = num % 10;
  if(num<num2)
      return num2;
  else return num1;
}
int randNumber = new Random().Next(10, 100);
Console.WriteLine(GetMaxNumber(randNumber));
Console.WriteLine($"input number {randNumber} max number {GetMaxNumber(randNumber)}");
*/
/*
2
bool Kratnoe(int num, int div1, int div2)
{
  if(num % div1 == 0 && num % div2 == 0)
  {
    return true;
  }
  return false;
}
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель1 ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель 2 ");
int div2 = Convert.ToInt32(Console.ReadLine());
bool result = Kratnoe(num, div1, div2);
Console.WriteLine($"Результат: {result}");
*/
/*
bool SquareNumber(int num1 , int num2)
{
    if(num1 == num2 * num2 || num2 == num1 * num1)
    {
        return true ; 
    }
    return false ;
}
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = SquareNumber(num1 , num2);
Console.WriteLine($"Результат работы: {result}");
*/