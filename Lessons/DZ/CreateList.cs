using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DZ
{
  public class CreateList
  {
    public static void MakeList()
    {
      List<List<int>> arrayList = new List<List<int>>(); // динамический двумерный массив
      int m; // количество колонок введенных пользователем
      Console.Write("Введите количество колонок списка: ");
      m = int.Parse(Console.ReadLine());

      var r = new Random(); //Random для числа строк
      int n = r.Next(10, 10000);

      arrayList=GenerateArrayList(m, n, arrayList);

      Console.WriteLine("нажмите любую клавишу для вывода списка в консоль...");
      Console.ReadKey();
      PrintArrayList(m,n,arrayList);

      

      Console.WriteLine("Нажмити любую клавишу для сортировки списка");
      Console.ReadKey();
      SortArrayList(arrayList);

      Console.ReadKey();
    }

    private static void PrintArrayList(int m, int n, List<List<int>> arrayList)
    {
      for (int i = 0; i < n; i++)                     //вывод массива
      {
        for (int j = 0; j < m; j++)
          Console.Write(arrayList[i][j].ToString() + " | ");
        Console.WriteLine();
      }
    }

    private static List<List<int>> SortArrayList(List<List<int>> arrayList)
    {
      
      Console.WriteLine("Метод на стадии реализации...");
      return arrayList;
    }

    private static List<List<int>> GenerateArrayList(int m, int n, List<List<int>> arrayList)
    {
      List<int> row = new List<int>(); // строка массива

      var num = new Random();

      // создание списка
      for (int i = 0; i < n; i++)
      {
        row = new List<int>();
        for (int j = 0; j < m; j++)
        {
          row.Add(num.Next(0, 100));
        }
        arrayList.Add(row);
      }
      Console.WriteLine("Список создан.");
      Console.WriteLine($"Колличество строк: {n}, Колличество колонок: {m}");
      return arrayList;
    }
  }
}
