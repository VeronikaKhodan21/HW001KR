﻿// Написать программу, которая из имеющегося массива строк формирует
//новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами
string[] A = new string[] {"Hello", "2", "world", ":-."};
void Chec(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
     char [] CharArray =A[i].Select(c => c).ToArray();   
     if(3>= CharArray.Length){
        Console.Write($"{array[i]} ");
     }
    }
}
Chec(A);




