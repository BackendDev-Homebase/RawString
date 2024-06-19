namespace RawString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simpleRawString = """"Das ist ein einfacher RawString""""; // mindestens 3 "
            
            var oldMultilineString = @"
Das ist ein alter String über mehrere Zeilen.
"" muss escaped werden.
";
            var rawString = """
                Das ist ein RawString über mehrere Zeilen.
                  " muss nicht excaped werden.
                """; // bessere Lesbarkeit wegen Einrückung; """ am Ende legen Einrückung fest

            Console.WriteLine(oldMultilineString);
            Console.WriteLine();
            Console.WriteLine(rawString);

            var oldInterpolatedMultilineString = $@"
  Erste Zeile {{
{simpleRawString}
Letzte Zeile
";
            var interpolatedRawString = $$"""
                Erste Zeile {
             {{simpleRawString}}
             Letzte Zeile
             """; // Anzahl an $ gibt Anzahl an { an


            Console.WriteLine(oldInterpolatedMultilineString);
            Console.WriteLine();
            Console.WriteLine(interpolatedRawString);

            Console.ReadKey();
        }
    }
}
