// Задача: Написать программу, которая из 
// имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


int sizeUserArr = SizeArray();
string[] arr = new string[sizeUserArr];
ArrCollect(arr, sizeUserArr);
PrintArray(arr);
Strelka();
int howSizeArrFresh = HowSizeArrFresh(arr);
string[] arrFresh = new string[howSizeArrFresh];
GetArrFresh(arr, arrFresh);
PrintArray(arrFresh);

int SizeArray() // запрашиваем и получаем длину массива от пользователя
{
  Console.Write("Введите длину массива натуральным числом: ");
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

void ArrCollect(string[] array, int sizeArray) // наполняем первый массив данными пользователя
{
  for (int i = 0; i < sizeArray; i++)
  {
    Console.Write($"Введите значение № {i+1}: ");
    array[i] = Convert.ToString(Console.ReadLine());
  }
}

int HowSizeArrFresh (string[] arrOld) // определяем длину для нового массива
{
  int count = 0;
  for (int i = 0; i < arrOld.Length; i++)
  {
    if (arrOld[i].Length <=3)
    {
      count++;
    }
  }
  return count;
}

void GetArrFresh (string[] arrOld, string[] arrNew) // наполняем новый массив
{
  int j = 0;
  for (int i = 0; i < arrOld.Length; i++)
  {
    if (arrOld[i].Length <=3)
    {
      arrNew[j] = arrOld[i];
      j++;
    }
  }
}

void PrintArray(string[] arr) // выводим массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void Strelka()
{
  Console.Write(" -> ");
}