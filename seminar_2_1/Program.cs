﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то 
//программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Напишите программу, которая принимает 
//на вход число и проверяет, 
//кратно ли оно одновременно 
// 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

int num = new Random().Next(100, 1000);
int num1 = num / 10;
int num2 = num % 10;

Console.WriteLine(num);

Console.WriteLine(num2);
if (num1 > num2)
{
    Console.WriteLine(num1);
}
else
    Console.WriteLine(num2);