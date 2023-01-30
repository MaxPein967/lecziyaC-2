// Напишите программу, которая 
// выводит случайное трехзначное 
// число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int digitsCount = (int)Math.Log10(number) + 1; // всего цифр в числе
int multiplier = (int)Math.Pow(10, digitsCount - 2); // множитель предпоследнего разряда
int result = number % multiplier + number / multiplier / 10 * multiplier; // все что справа от разряда + все что слева, делённое на 10
Console.WriteLine(result); 