using System;
using System.Diagnostics;
using myConsoleApp.Models;
using ConsoleTables;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

#region  1.Abfrage
// internal class NewBaseType
// {
//     private static void Main(string[] args)
//     {
//         var array = Enumerable.Range(1, 100).ToList();
//         var resultat = array.AsParallel().Where(nummer => nummer % 2 == 0).ToList();
//         resultat.ToList().ForEach(x =>
//         {
//             Console.WriteLine($"Nummer {x} wurde mit Nummer {Thread.CurrentThread.ManagedThreadId} Thread gerechnet.");
//         });
//     }
// }
#endregion

#region 2.Abfrage
public class Program
{

    private static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        System.Console.WriteLine("Der Vorgang wurde ausgeführt");
        AdventureWorks2019Context? kontext = new AdventureWorks2019Context();
        var produkte = kontext?.Products?.AsParallel().Where(p => p.ListPrice > 10M).Take(20).ToList();

        ConsoleTable table = new ConsoleTable("Name", "List Price");
        produkte?.ForEach(p =>
        {
            table.AddRow(p.Name, p.ListPrice);
        });
        table.Write(Format.Alternative);
        sw.Stop();
        System.Console.WriteLine($"Der Vorgang wurde in {sw.ElapsedMilliseconds} Millisekunden beendet");
    }
}
#endregion

#region Benchmark 
// public class BenchmarkExample
// {
    
//     [Benchmark]
//     public void MathPow()
//     {
//         double result = Math.Pow(2, 3);
//     }

//     [Benchmark]
//     public void StringConcatenation()
//     {
//         string str1 = "hello";
//         string str2 = "world";
//         string result = str1 + " " + str2;
//     }

//     [Benchmark]
//     public void StringBuilder()
//     {
//         var stringBuilder = new System.Text.StringBuilder();
//         string str1 = "hello";
//         string str2 = "world";
//         stringBuilder.Append(str1).Append(" ").Append(str2);
//         string result = stringBuilder.ToString();
//     }
// }

// class Program
// {    
//     static void Main(string[] args)
//     {
//         var summary = BenchmarkRunner.Run<BenchmarkExample>();
//     }
// }
#endregion

#region Benchmark-2
//     public class MyClass
//     {
//         [Benchmark]
//         public void MyMethod()
//         {
//             AdventureWorks2019Context? kontext = new AdventureWorks2019Context();
//             var produkte = kontext?.Products?.AsParallel().Where(p => p.ListPrice > 10M).Take(20).ToList();
//         }
//     }
// class Program
// {
//     private static void Main(string[] args)
//     {
//         AdventureWorks2019Context? kontext = new AdventureWorks2019Context();

//         var produkte = kontext?.Products?.AsParallel().Where(p => p.ListPrice > 10M).Take(20).ToList();

//         produkte?.ForEach(p =>
//         {
//             System.Console.WriteLine($"{p.Name} - {p.ListPrice}");
//         });

//         var resultat = BenchmarkRunner.Run<MyClass>();

//     }
// }
#endregion