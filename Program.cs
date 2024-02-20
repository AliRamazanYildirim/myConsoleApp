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
// class Program
// {
//     static void Main(string[] args)
//     {
//         int zahl = 0, summe = 0;
//         while (true)
//         {
//             Console.WriteLine("Geben Sie eine Zahl ein");
//             zahl = Convert.ToInt32(Console.ReadLine());
//             if (zahl < 0)
//             {
//                 break;
//             }
//             summe += zahl;
//         }
//         Console.WriteLine("Summe der eingegebenen Zahlen :" + summe);
//         Console.ReadKey();
//     }
// }
#endregion

#region Interview-Frage-3
// Print fibonacci series

// class Program
// {
//     static void Main(string[] args)
//     {
//         int n1 = 0;
//         int n2 = 1;
//         int n3 = 0;
//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine(n1);
//             n3 = n1 + n2;
//             n1 = n2;
//             n2 = n3;
//         }
//         Console.ReadKey();
//     }
// }
#endregion

#region Interview-Frage-4
//PrimzahlPrüfung

// namespace PrimzahlPrüfung
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Geben Sie eine Zahl ein:");
//             int zahl = Convert.ToInt32(Console.ReadLine());

//             if (IstPrimzahl(zahl))
//                 Console.WriteLine(zahl + " ist eine Primzahl.");
//             else
//                 Console.WriteLine(zahl + " ist keine Primzahl.");
//         }

//         static bool IstPrimzahl(int num)
//         {
//             if (num < 2)
//                 return false;

//             // Nummer 2 ist die einzige gerade Primzahl.
//             if (num != 2 && num % 2 == 0)
//                 return false;

//             // Überprüfen Sie alle Zahlen von 3 bis zur Quadratwurzel von Num.
//             for (int i = 3; i <= Math.Sqrt(num); i += 2)
//             {
//                 if (num % i == 0)
//                     return false;
//             }

//             return true;
//         }
//     }
// }

#endregion

#region Interview-Frage-5

// namespace Frage
// {
//     class Program
//     {
//         static void Main()
//         {
//             string[] fruchte = { "Apfel", "Birne", "Banane", "Kirsche" };

//             // 1. Frucht auf der Konsole ausgeben
//             Console.WriteLine(fruchte[0]);

//             // Index der Frucht "Banane" im Array ermitteln
//             int index = Array.IndexOf(fruchte, "Banane");
//             Console.WriteLine("Index der Banane im Array: " + index);

//             // Größe des Arrays bestimmen
//             int groesse = fruchte.Length;
//             Console.WriteLine("Größe des Arrays: " + groesse);
//         }
//     }
// }
#endregion

#region Interview-Frage-6
// using System;

// class MainClass
// {
//   public static string FirstReverse(string str)
//   {
//         // code goes here
//         char[] charArray = str.ToCharArray();
//         // Kehrt die Zeichenkette um.
//         Array.Reverse(charArray);
//         // Verketten Sie die invertierte Zeichenfolge und geben Sie das Ergebnis zurück
//         return new string(charArray);
//   }
//   static void Main()
//   {
//     // keep this function call here
//     Console.WriteLine("Enter a string: ");
//         string input = Console.ReadLine();
//         string reversed = FirstReverse(input);

//         Console.WriteLine("Reversed string: " + reversed);
//   }
// }
#endregion

#region Interview-Frage-7
// using System;

// class MainClass {
//     public static int FirstFactorial(int num) {
//         int factorial = 1;
//         for (int i = num; i > 0; i--) {
//             factorial *= i;
//         }
//         return factorial;
//     }

//     static void Main() {
//         Console.WriteLine("Enter a number: ");
//         int input = Convert.ToInt32(Console.ReadLine());
//         int result = FirstFactorial(input);

//         Console.WriteLine("Factorial: " + result);
//     }
// }
#endregion

#region Interview-Frage-8
// using System;
// namespace ConsoleApp
//  {
//      class Program
//      {
//         static void Main(string[] args)
//         {
//             bool ergebnis=false||true;
//             Console.WriteLine(ergebnis);

//             ergebnis |=false;
//             Console.WriteLine(ergebnis);

//             ergebnis =! ergebnis;
//             Console.WriteLine(ergebnis);

//             ergebnis |=!false;
//             Console.WriteLine(ergebnis);
//         }
//      }
//  }
#endregion

#region Beispiel-1
// using System;
// namespace ConsoleApp
//  {
//      class Program
//      {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Wie wäre es mit Horror?");
//             bool horror=bool.Parse(Console.ReadLine());
//             if(horror)
//             Console.WriteLine("Gute Wahl wird es heute gruselig :) ");
//             else
//             {
//                 Console.WriteLine("Wie wäre ein Actionfilm?");
//                 bool action= bool.Parse(Console.ReadLine());
//                 if(action)
//                 Console.WriteLine("Ein toller Actionfilm ist immer toller.");
//                 else
//                 {
//                     Console.WriteLine("Was sagst du für ein Thriller?");
//                     bool thriller=bool.Parse(Console.ReadLine());
//                     if(thriller)
//                     Console.WriteLine("Wow es wird bestimmt spanned");
//                     else
//                     Console.WriteLine("Dann gibt es heute kein Fersehen");
//                 }
//             }
//         }
//      }
//  }
#endregion

#region Beispiel-2
// using System;
// namespace ConsoleApp
//  {
//      class Program
//      {
//         static void Main(string[] args)
//         {
//            string text=null;
//            Console.WriteLine(text.Length);
//            Console.ReadKey();

//         }
//      }
//  }
#endregion

#region Beispiel-3
// using System;
// namespace ConsoleApp
//  {
//      class Program
//      {
//         static void Main(string[] args)
//         {
//            System.Console.WriteLine("Text eingeben");
//            string text=Console.ReadLine();
//            string neuerText="";
//            for(int i=text.Length-1;i>=0;i--)
//            neuerText+=text[i];
//            Console.WriteLine("Der Text rückwaerts:{0}",neuerText);
//         }
//      }
//  }
#endregion

#region Beispiel-4
// using System;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static Random rnd = new Random(DateTime.Now.Millisecond);
//         static void GeneriereSchuhenummern(string[] schuhe, int zeichenAnzahl)
//         {
//             for (int i = 0; i < schuhe.Length; i++)
//             {
//                 char[] nummer = new char[zeichenAnzahl];
//                 for (int j = 0; j < zeichenAnzahl; j++)
//                 {
//                     nummer[j] = (char)rnd.Next(97, 123);
//                     schuhe[i] = new String(nummer);
//                 }
//             }
//         }
//         static void Main(string[] args)
//         {
//             int zeichenAnzahl = 7;
//             String[] ihreSchuhe = new String[10000];
//             String[] imGeschaeft = new String[1000000];
//             Console.WriteLine("Generiere Schuhe ...");
//             GeneriereSchuhenummern(ihreSchuhe, zeichenAnzahl);
//             GeneriereSchuhenummern(imGeschaeft, zeichenAnzahl);
//             Console.WriteLine("Suche Übereinstimmungen ...");
//             DateTime start = DateTime.Now;
//             List<string> neueSchuhe = new List<string>(imGeschaeft.Length - ihreSchuhe.Length);
//             HashSet<string> ihreSchuheHashSet = new HashSet<string>();
//             for (int i = 0; i < ihreSchuhe.Length; i++)
//                 ihreSchuheHashSet.Add(ihreSchuhe[i]);
//             for (int i = 0; i < imGeschaeft.Length; i++)
//                 if (ihreSchuheHashSet.Add(imGeschaeft[i]))
//                     neueSchuhe.Add(imGeschaeft[i]);
//             Console.WriteLine("Dauer: {0} ms", DateTime.Now.Subtract(start).TotalMilliseconds);
//             Console.WriteLine("Deine Freundin kann sich noch weitere {0} Paar Schuhe kaufen", neueSchuhe.Count);
//         }
//     }
// }
#endregion

#region Beispiel-5
// using System;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Ghost ghost = new Ghost("Casper");
//             ghost.Haunt();
//         }

//         class Ghost
//         {
//             public Ghost(string name)
//             {
//                 this.Name = name;
//             }

//             public string Name { get; set; }

//             public virtual void Haunt()
//             {
//                 Console.WriteLine("{0} sagt:'Buh'", this.Name);
//             }
//         }
//         class SlimeGhost:Ghost{
//             public SlimeGhost(string name):base(name){}
//             public override void Haunt(){
//                 this.Slime();
//                 base.Haunt();
//             }
//             public void Slime(){
//                 Console.WriteLine("{0} hinterlaesst eine Schleimspur.",this.Name);
//             }
//         }
//     }
// }
#endregion

#region Beispiel-6
// using System;
// namespace ConsoleApp
//  {
//      class Program
//      {
//         static void Main(string[] args)
//         {
//            const int num_count=100;
//            int[] numbers=new int[num_count];
//            Random rnd=new Random();
//            for(int i=0;i<numbers.Length;i++)
//            numbers[i]=rnd.Next(0,numbers.Length);

//            Console.WriteLine("Bitte Zahl zum Suchen eingeben:");
//            int suche=Convert.ToInt32(Console.ReadLine());
//            for(int i=0;i<numbers.Length;i++)
//            if(numbers[i]==suche)
//            {
//                 Console.WriteLine("Gefunden! Die Zahl {0} steht an Stelle {1}", suche,i);
//                 break;
//            }
//         }
//      }
//  }
#endregion

#region Beispiel-7
// using System;

// namespace ConsoleApp
// {
//     abstract class Shape
//     {
//         public int Top { get; set; }
//         public int Left { get; set; }
//         public virtual int Width { get; set; }
//         public virtual int Height { get; set; }
//         public ConsoleColor Color { get; set; }

//         public bool IsCollision(Shape s)
//         {
//             return (s.Top < this.Top && s.Top + s.Height > this.Top ||
//                     this.Top < s.Top && this.Top + this.Height > s.Top &&
//                     (s.Left < this.Left && s.Left + s.Width > this.Left ||
//                     this.Left < s.Left && this.Left + this.Width > s.Left));
//         }

//         public void DrawShapeBeforeMe(Shape s)
//         {
//             s.Draw();
//             // this.Draw();
//         }

//         public abstract void Draw();
//     }

//     class MyShape : Shape
//     {
//         public override void Draw()
//         {
//             Console.WriteLine("Drawing MyShape");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             MyShape myShape = new MyShape();
//             myShape.DrawShapeBeforeMe(new MyShape());
//         }
//     }
// }
#endregion

#region Beispiel-8
// using System;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static DateTime timer;
//         static Random rnd = new Random(DateTime.Now.Millisecond);

//         static void StartMeasure(string text)
//         {
//             Console.WriteLine(text);
//             timer = DateTime.Now;
//         }

//         static void EndMeasure(string text)
//         {
//             double seconds = DateTime.Now.Subtract(timer).TotalMilliseconds;
//             Console.WriteLine("{0}: {1} sec", text, seconds);
//             timer = DateTime.Now;
//         }

//         private static void Arrays(int amount, int searchAmount)
//         {
//             StartMeasure("Array");
//             int[] data = new int[amount];
//             for (int i = 0; i < amount; i++)
//                 data[i] = rnd.Next(amount);
//             EndMeasure("Array fill");

//             for (int i = 0; i < searchAmount; i++)
//             {
//                 int search = rnd.Next(amount);
//                 for (int j = 0; j < amount; j++)
//                     if (data[i] == search)
//                         break;
//             }
//             EndMeasure(String.Format("Searched for {0} times", searchAmount));
//         }

//         private static void Lists(int amount, int searchAmount)
//         {
//             StartMeasure("List");
//             List<int> list = new List<int>();
//             for (int i = 0; i < amount; i++)
//                 list.Add(rnd.Next(amount));
//             EndMeasure("List fill");

//             for (int i = 0; i < searchAmount; i++)
//             {
//                 int search = rnd.Next(amount);
//                 bool contains = list.Contains(search);
//             }
//             EndMeasure(String.Format("Searched for {0} times", searchAmount));
//         }

//         private static void Dictionaries(int amount, int searchAmount)
//         {
//             StartMeasure("Dictionary");
//             Dictionary<int, int> list = new Dictionary<int, int>();
//             for (int i = 0; i < amount; i++)
//             {
//                 int val = rnd.Next(amount);
//                 if (!list.ContainsKey(val))
//                     list.Add(val, val);
//             }
//             EndMeasure("Dictionary fill");

//             for (int i = 0; i < searchAmount; i++)
//             {
//                 int search = rnd.Next(amount);
//                 bool contains = list.ContainsKey(search);
//             }
//             EndMeasure(String.Format("Searched for {0} times", searchAmount));
//         }

//         static void Main(string[] args)
//         {
//             Arrays(100, 10);
//             Lists(100, 10);
//             Dictionaries(100, 10);
//         }
//     }
// }

#endregion

#region Beispiel-9
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        class Speise
        {
            public int KiloKalorien { get; }
            public string Name { get; }

            public Speise(string name, int kiloKalorien)
            {
                Name = name;
                KiloKalorien = kiloKalorien;
            }
        }

        static void Main(string[] args)
        {
            List<Speise> speisen = new List<Speise>
            {
                new Speise("Icli Köfte", 250),
                new Speise("Anali-kizli", 350),
                new Speise("Karniyarik", 550),
                new Speise("Kadinbudu köfte", 370),
                new Speise("Hünkarbegendi", 250)
            };

            var katSpeisen = from s in speisen
                             group s by s.KiloKalorien > 300 into gruppe
                             select gruppe;

            foreach (var gruppe in katSpeisen)
            {
                Console.WriteLine(gruppe.Key ? "\nLeckere Speise" : "\nDiaettaugliche Speise");
                foreach (var speise in gruppe)
                {
                    Console.WriteLine("{0} kcal\t{1}", speise.KiloKalorien, speise.Name);
                }
            }
        }
    }
}
#endregion
