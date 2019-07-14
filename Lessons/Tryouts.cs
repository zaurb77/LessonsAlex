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

      List<List<int>> list = new List<List<int>>
      {
        new List<int> { 5, 9, 17, 40, 99 },
        new List<int> { 12, 24, 30, 45, 80 },
        new List<int>() { 5, 9, 17, 16, 99 },
        new List<int>() { 0, 9, 17, 16, 0 },
        new List<int>() { 129, 5, 8, 15, 25 } };

      // display list in console
      List<List<int>> sortedList = new List<List<int>>();
      IEnumerable<List<int>> rlist = list.Select(
      lst => lst.OrderBy(i => i).ToList());


      sortedList = rlist.OrderBy(lst => lst[0]).ThenBy(lst => lst[1]).ThenBy(lst => lst[2]).ToList();

      int lastColumn = 4;

      //sortedList = rlist.OrderBy(lst => lst[0]).ThenBy(lst => lst.).ToList();
      //sequence.OrderBy(x => x.A).ThenBy(x => x.B)




      CreateList.PrintArrayList(5, sortedList.Count, sortedList);



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
