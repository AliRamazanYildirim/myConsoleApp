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
// public class Program
// {

//     private static void Main(string[] args)
//     {
//         Stopwatch sw = new Stopwatch();
//         sw.Start();
//         System.Console.WriteLine("Der Vorgang wurde ausgeführt");
//         AdventureWorks2019Context? kontext = new AdventureWorks2019Context();
//         var produkte = kontext?.Products?.AsParallel().Where(p => p.ListPrice > 10M).Take(20).ToList();

//         ConsoleTable table = new ConsoleTable("Name", "List Price");
//         produkte?.ForEach(p =>
//         {
//             table.AddRow(p.Name, p.ListPrice);
//         });
//         table.Write(Format.Alternative);
//         sw.Stop();
//         System.Console.WriteLine($"Der Vorgang wurde in {sw.ElapsedMilliseconds} Millisekunden beendet");
//     }
// }
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

#region IP Finder
// using System;
// using System.Net;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Geben Sie den Domänennamen ein: ");
//             var domain = Console.ReadLine();

//             if (!string.IsNullOrEmpty(domain))
//             {
//                 var ipAddresses = Dns.GetHostAddresses(domain);

//                 ipAddresses.ToList().ForEach(ip =>
//                 {
//                     {
//                         Console.WriteLine(ip);
//                     }
//                 });

//             }
//             else
//             {
//                 Console.WriteLine("Der Domänenname darf nicht leer sein.");
//             }

//             Console.ReadKey();
//         }
//     }
// }
#endregion

#region Mit Netzwerk-Schnittstelle  IP-Adressen auflisten
// using System;
// using System.Net;
// using System.Net.NetworkInformation;
//  class Program
// {
//     static void Main(string[] args)
//     {
//         NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
//          foreach (NetworkInterface ni in interfaces)
//         {
//             Console.WriteLine("Name: {0}", ni.Name);
//             Console.WriteLine("Beschreibung: {0}", ni.Description);
//             Console.WriteLine("Status: {0}", ni.OperationalStatus);
//             Console.WriteLine("MAC-Adresse: {0}", ni.GetPhysicalAddress().ToString());
//              IPInterfaceProperties ipProps = ni.GetIPProperties();
//             foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
//             {
//                 Console.WriteLine("IP-Adresse: {0}", addr.Address.ToString());
//                 Console.WriteLine("Subnetzmaske: {0}", addr.IPv4Mask.ToString());
//                 Console.WriteLine();
//             }
//              Console.WriteLine();
//         }
//     }
// }
#endregion

#region Pdf Erstellen
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Encoding utf8 = Encoding.GetEncoding("UTF-8");

PdfDocument pdf = new PdfDocument();
pdf.Info.Title = "Meine erste PDF";
PdfPage pdfPage = pdf.AddPage();
XGraphics graph = XGraphics.FromPdfPage(pdfPage);
XFont font = new XFont("Verdana", 20, XFontStyle.Regular);
graph.DrawString("Hallo Welt!", font, XBrushes.Black,
new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point),
XStringFormats.Center);
string pdfFilename = "meineerstePDF.pdf";
pdf.Save(pdfFilename);

#endregion