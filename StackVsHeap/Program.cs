using System;

namespace StackVsHeap
{
  class Program
  {
    static void Main(string[] args)
    {
      BasicStackVsHeap();
    }

    private static void BasicStackVsHeap()
    {
      Console.WriteLine("Stacking vs Heaping");
      
      Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
      
      var stackedValue = DoStack();
      Console.WriteLine("Total Memory After Stack: {0}", GC.GetTotalMemory(false));
      Console.WriteLine("Stacked Value {0}", stackedValue);
      
      var heapedValue = DoHeap();
      Console.WriteLine("Total Memory After Heap: {0}", GC.GetTotalMemory(false));
      Console.WriteLine("Heaped Value {0}", heapedValue);
    }

    private static int DoStack()
    {
      int x = 5;
      
      for (int i = 0; i < 1000; i++)
      {
        int y = x;
        y = 4; 
      }

      return x;
    }

    private static int DoHeap()
    {
      var x = new CustomInt
      {
        Value = 5
      };

      for (int i = 0; i < 1000; i++)
      {
        var y = new CustomInt();
        y = x;
        y.Value = 4; 
      }
      
      return x.Value;
    }
  }
}