using System;
using System.IO;

namespace TextAnalyzer.app;

class Program
{
    static void Main(string[] args)
    {
        string textToAnalyze = "";

        if (args.Length > 0)
        {
            string filePath = args[0];
            if (File.Exists(filePath))
            {
                textToAnalyze = File.ReadAllText(filePath);
            }
            else
            {
                Console.WriteLine("Blad, nie ma takiego pliku");
                return;
            }
            
            }
            else
            {
            Console.WriteLine("Podaj tekst do analizy:");
            textToAnalyze = Console.ReadLine();
            
        }

        var stats = TextAnalyzer.AnalyzeText(textToAnalyze);
        Console.WriteLine("\nStatystyki tekstu");
        Console.WriteLine($"Liczba znakow (ze spacjami): {stats.CharacterCount}");
        Console.WriteLine($"Liczba slow: {stats.WordCount}");
        Console.WriteLine($"Liczba zdan: {stats.SentenceCount}");
        Console.WriteLine($"Najczestsze slowo: {stats.MostCommonWord}");
        Console.WriteLine($"Srednia dlugosc slowa: {stats.AverageWordLength:F2}");
        Console.WriteLine($"Liczba znakow bez spacji: {stats.CharacterCountWithoutSpace}");
        Console.WriteLine($"Liczba liter bez znakow specjalnych: {stats.CharacterCountWithoutSpecial} ");
        Console.WriteLine($"Liczba cyfr: {stats.DigitCount}");
        Console.WriteLine($"Liczba znakow interpunkcyjnych: {stats.MarkCount}");
        Console.WriteLine($"Liczba unikalnych slow: {stats.UniqueWord}");
        Console.WriteLine($"Srednia liczba slow na zdanie: {stats.AverageCountWordPerSentence}");
        Console.WriteLine($"Najdluzsze zdanie: {stats.LongestSentence}");
        Console.WriteLine($"Najdluzsze slowo: {stats.LongestWord}");
        Console.WriteLine($"Najkrotsze slowo: {stats.ShortestWord}");
    }
}