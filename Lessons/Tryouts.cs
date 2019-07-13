using System;
using System.Collections.Generic;
using System.Linq;
using Lessons.DZ;

namespace Lessons
{
  class Tryouts
  {
    public static void Test()
    {
      var arrayList = new List<List<int>>();

      // add rows to a list of rows
      List<int> row = new List<int>() {1, 6, 3, 156, 10};
      arrayList.Add(row.ToList());
      row = new List<int>() {12, 8, 1, 2, 30};
      arrayList.Add(row.ToList());
      row = new List<int>() {5, 4, 8, 12, 25};
      arrayList.Add(row.ToList());
      row = new List<int>() {3, 2, 3, 16, 9};
      arrayList.Add(row.ToList());

      // display list in console
      CreateList.PrintArrayList(row.Count, arrayList.Count, arrayList);


      // sort rows ascending
      var sortedRowsList = CreateList.SortArrayList(arrayList, row.Count);
      Console.WriteLine();
      Console.WriteLine("Sorted IList...");
      CreateList.PrintArrayList(row.Count, sortedRowsList.Count, sortedRowsList);

      //var newList = people.OrderBy(x=>x.LastName).ToList(); // ToList optional

      var sortedByRowsAndColumns = new List<List<int>>();

      sortedByRowsAndColumns = sortByRowsAndColumns(sortedRowsList, row.Count, sortedRowsList.Count);




      Console.ReadKey();
    }

    private static List<List<int>> sortByRowsAndColumns(List<List<int>> sortedRowsList, int count1, int count2)
    {
      sortedRowsList.Sort((List<int> x, List<int> y) =>
        {
          if (x.Sum() == y.Sum()) return 0;
          if (x.Sum() > y.Sum()) return 1;
          return -1;
        }
      );
      //CreateList.PrintArrayList(m, sortedRowsList.Count, sortedRowsList);
      return sortedRowsList;
    }
  }
}
