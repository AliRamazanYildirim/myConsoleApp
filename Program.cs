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
// using PdfSharp.Pdf;
// using PdfSharp.Drawing;
// using System.Text;

// Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
// Encoding utf8 = Encoding.GetEncoding("UTF-8");

// PdfDocument pdf = new PdfDocument();
// pdf.Info.Title = "Meine erste PDF";
// PdfPage pdfPage = pdf.AddPage();
// XGraphics graph = XGraphics.FromPdfPage(pdfPage);
// XFont font = new XFont("Verdana", 20, XFontStyle.Regular);
// graph.DrawString("Hallo Welt!", font, XBrushes.Black,
// new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point),
// XStringFormats.Center);
// string pdfFilename = "meineerstePDF.pdf";
// pdf.Save(pdfFilename);

#endregion

#region Pdf-Konvertierung

// using System.IO;
// using iText.Kernel.Pdf;
// using iText.Layout;
// using iText.Layout.Element;

// namespace TextToPdf
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create a new PDF document
//             string fileName = "output_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
//             PdfDocument pdf = new PdfDocument(new PdfWriter(fileName));
//             Document doc = new Document(pdf);

//             // Read the text file line by line
//             using (StreamReader sr = new StreamReader("datei.txt"))
//             {
//                 string? line;
//                 while ((line = sr.ReadLine()) != null)
//                 {
//                     // Add each line to the PDF document
//                     Paragraph para = new Paragraph(line);
//                     doc.Add(para);
//                 }
//             }

//             // Close the document
//             doc.Close();
//         }
//     }
// }

#endregion

#region IP Filter

// using System.Net;

// IPAddress ipAddress = IPAddress.Parse("::1");
// if (IPAddress.IsLoopback(ipAddress))
// {
//     Console.WriteLine("Die IP-Adresse ist eine Loopback-Adresse.");
// }
// else
// {
//     Console.WriteLine("Die IP-Adresse ist nicht eine Loopback-Adresse.");
// }

#endregion

#region Verwaltung von IP-Adressen
// using System.Net;
// using System.Net.Sockets;

// namespace RemoteAccess
// {
//     class Program
//     {
//         static  void Main(string[] args)
//         {
//             // IP-Adresse, zu der eine Verbindung hergestellt werden soll
//             string ipAddress = "2011:c7:9f16:9864:4447:df91:46be:39af";

//             try
//             {
//                 TcpClient client = new TcpClient();
//                 client.ConnectAsync(ipAddress, 80);

//                 Console.WriteLine("Erlaubte IP-Adresse: " + ipAddress);
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine(ex.Message);
//             }

//             Console.ReadLine();
//         }
//     }
// }
#endregion

#region Ref Person
// class Person
// {
//     public string? Name { get; set; }
//     public int Alter { get; set; }

//     public void ChangePerson(ref Person person, string neuerName, int neuesAlter)
//     {
//         person.Name = neuerName;
//         person.Alter = neuesAlter;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         int ersterWert, zweiterWert;

//         GetValues(out ersterWert, out zweiterWert);
//         Console.WriteLine($"Erster Wert: {ersterWert}, Zweiter Wert: {zweiterWert}");

//         Person ali = new Person();
//         ali.Name = "Ali";
//         ali.Alter = 25;

//         Console.WriteLine($"Bevor: Name = {ali.Name}, Alter = {ali.Alter}");

//         ali.ChangePerson(ref ali, "Ramazan", 30);

//         Console.WriteLine($"Danach: Name = {ali.Name}, Alter = {ali.Alter}");
//     }

//     public static void GetValues(out int wert1, out int wert2)
//     {
//         wert1 = 10;
//         wert2 = 20;
//     }
// }
#endregion

#region Interview-Frage 
// class Program
// {
//     static void Main(string[] args)
//     {
//         int  i=1;
//         int j=1;
//         for(;i<3;i++)
//         {
//             j+=i;
//         }
//         Console.WriteLine("j="+j);
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         int  i=1;
//         int j=1;
//         for(;i<5;i++)
//         {
//             j+=i;
//             Console.WriteLine("i=" + i + ", j=" + j);
//         }
//         Console.WriteLine("Final i=" + i + ", Final j=" + j);
//     }
// }

#endregion

#region Interview-Frage-2
//Ein Programm, das die eingegebenen Zahlen addiert, bis eine negative Zahl eingegeben wird.
class Program
{
    static void Main(string[] args)
    {
        int zahl = 0, summe = 0;
        while (true)
        {
            Console.WriteLine("Geben Sie eine Zahl ein");
            zahl = Convert.ToInt32(Console.ReadLine());
            if (zahl < 0)
            {
                break;
            }
            summe += zahl;
        }
        Console.WriteLine("Summe der eingegebenen Zahlen :" + summe);
        Console.ReadKey();
    }
}
#endregion