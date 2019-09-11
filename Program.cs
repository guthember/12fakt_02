using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismetles2
{
  class Program
  {
    static void Main(string[] args)
    {
      // tömb létrehozása adatokkal
      // indexekkel hivatkozunk a tömb elemeire
      // első elem indexe = 0!!!
      // utolsó elem indexe = darabszám - 1
      int[] tomb = new int[] {1,2,3,4,5,6};

      Console.WriteLine("A tömb hossza: {0}",tomb.Length);
      Console.WriteLine("Elemei:");
      for (int i = 0; i < tomb.Length; i++)
      {
        Console.WriteLine(tomb[i]);
      }

      // Véletlen számokkal feltöltve
      int[] ujTomb = new int[10];

      // tök jó: Random vel = new Random();
      Random vel = new Random(Guid.NewGuid().GetHashCode());

      for (int i = 0; i < ujTomb.Length; i++)
      {
        // értékei: [1-100]
        ujTomb[i] = vel.Next(1, 101);
      }

      Console.WriteLine("\nÚj tömb elemei: ");
      for (int i = 0; i < ujTomb.Length; i++)
      {
        Console.WriteLine(ujTomb[i]);
      }

      Console.ReadKey();
    }
  }
}
