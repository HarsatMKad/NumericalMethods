using org.mariuszgromada.math.mxparser.mathcollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRatioMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      Application.Run(new MainForm());

      
      double x = 0.729876543242353452361 / Math.Pow(10,4);
      Console.WriteLine("неокругленный: " + x);

      Console.WriteLine("округленный round: " + Math.Round(x, 5));

      double a = Math.Truncate(x * Math.Pow(10, 5));
      Console.WriteLine("округленный: " + a / Math.Pow(10, 5));

      double b = Math.Truncate(x * Math.Pow(10, 5));
      Console.WriteLine(b);
      Console.ReadKey();
    }
  }
}
