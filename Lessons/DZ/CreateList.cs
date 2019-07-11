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
      
      // задаём динамический двумерный массив
      List<List<int>> arrayList = new List<List<int>>();
      
      // устанавливаем количество колонок введенных пользователем
      Console.Write("Введите количество колонок списка: ");
      var m = int.Parse(Console.ReadLine());

      // при помощи Random задаем число строк
      var r = new Random();
      var n = r.Next(10, 50);

      // генерируем двумерный список с данными
      arrayList=GenerateArrayList(m, n, arrayList);


      Console.WriteLine("нажмите любую клавишу для вывода списка в консоль...");
      Console.ReadKey();
      
      // выводим список в консоль
      PrintArrayList(m,n,arrayList);

      Console.WriteLine("Нажмити любую клавишу для сортировки строк списка");
      Console.ReadKey();

      // производим сортировку списка и вносим его в новый, сортированный, двумерный список
      List <List<int>> sortedArray;
      sortedArray=SortArrayList(arrayList, m);
      // выводим на консоль список с сортированными строками
      PrintArrayList(m, sortedArray.Count, sortedArray);

      Console.WriteLine("Нажмити любую клавишу для сортировки списка по колонкам");
      Console.ReadKey();
      // производим сортировку списка sortedArray по колонкам и заносим его в новый список
      List<List<int>> sortedArrayByColumns;
      sortedArrayByColumns = SortArrayListByColumns(sortedArray, m);
      // выводим на консоль список с сортированными строками
      PrintArrayList(m, sortedArrayByColumns.Count, sortedArray);

      Console.ReadKey();
    }

    private static List<List<int>> SortArrayListByColumns(List<List<int>> sortedArray, int m)
    {
      var sortedArrayByColumns= new List<List<int>>();

      //for (int row = 0; row < sortedArray.Count; row++)
      //{
      //  for (int column = 0; column < m; column++)
      //  {

      //  }
      //}

      List<int> sortedRow;

      for (int row = 0; row < sortedArray.Count; row++)
      {
        sortedRow = new List<int>();
        for (int column = 0; column < m; column++)
        {
          sortedRow.Add(sortedArray[row][column]);
          sortedRow.Sort();
        }
      }

     

      return sortedArrayByColumns;
    }

    private static void PrintArrayList(int m, int n, List<List<int>> arrayList)
    {
      for (int i = 0; i < n; i++) //вывод массива
      {
        for (int j = 0; j < m; j++)
          Console.Write(arrayList[i][j].ToString() + " | ");
        Console.WriteLine();
      }
    }

    private static List<List<int>> SortArrayList(List<List<int>> arrayList, int m)
    {
      List<int> sortedRow;

      var sortedArray = new List<List<int>>();

      for (int i = 0; i < arrayList.Count; i++)
      {
        sortedRow = new List<int>();
        for (int j = 0;j < m; j++)
        {
          sortedRow.Add(arrayList[i][j]);
          sortedRow.Sort();
        }
        sortedArray.Add(sortedRow);
      }

      return sortedArray;
    }

    private static List<List<int>> GenerateArrayList(int m, int n, List<List<int>> arrayList)
    {
      List<int> row; ; // строка массива

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
