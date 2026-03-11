namespace TextAnalyzer.app;

public class TextAnalyzer
{
    public static int CountCharacters(string text)
    {
        return text.Length;
    }

    public static int CountWords(string text)
    {
        var words = text.Split(new char[] { ' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    public static int CountSentences(string text)
    {
        var sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return sentences.Length;
    }

    public static string FindMostCommonWord(string text)
    {
        var words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.GroupBy(w => w.ToLower()).OrderByDescending(g => g.Count()).FirstOrDefault()?.Key ?? "";
    }

    public static float CalculateAverageWordLength(string text)
    {
        var words = text.Split(new char[] { ' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
        return (float)words.Average(w => w.Length);
    }

    public static int CalculateCharacterCountWithoutSpace(string text)
    {
        var characters = text.Count(c => !char.IsWhiteSpace(c));
        return characters;
    }

    public static int CalculateCharacterCountWithoutSpecial(string text)
    {
        var characters = text.Count(c => char.IsLetter(c));
        return characters;
    }

    public static int CalculateDigitCount(string text)
    {
        var digit = text.Count(d => char.IsDigit(d));
        return digit;
    }

    public static int CalculateMarkCount(string text)
    {
        var marks = text.Count(m => char.IsPunctuation(m));
        return marks;
    }

    public static int CalculateUniqueWord(string text)
    {
        var words = text.Split(new char[] { ' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
        var uniqueWord = words.Select(w => w.ToLower()).Distinct().Count();
        return uniqueWord;
    }

    public static float CalculateAverageCountWordPerSentence(string text)
    {
        var wordCount = CountWords(text);
        var sentenceCount = CountSentences(text);
        var wordsPerSentence = (float)wordCount / sentenceCount;
        return wordsPerSentence;
    }

    public static string SearchLongestSentence(string text)
    {
        var sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        var longestSentence = sentences.OrderByDescending(s => s.Split().Length).FirstOrDefault();
        return longestSentence;
    }

    public static string SearchLongestWord(string text)
    {
        var words = text.Split(new char[] { ' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
        var longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
        return longestWord;
    }

    public static string SearchShortestWord(string text)
    {
        var words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        var shortestWord = words.OrderBy(w => w.Length).FirstOrDefault();
        return shortestWord;
    }
    
    
    public static TextStatistics AnalyzeText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return new TextStatistics();
        }
        var stats = new TextStatistics();
        stats.CharacterCount = CountCharacters(text);
        stats.WordCount = CountWords(text);
        stats.SentenceCount = CountSentences(text);
        stats.MostCommonWord = FindMostCommonWord(text);
        stats.AverageWordLength = CalculateAverageWordLength(text);
        stats.CharacterCountWithoutSpace = CalculateCharacterCountWithoutSpace(text);
        stats.CharacterCountWithoutSpecial = CalculateCharacterCountWithoutSpecial(text);
        stats.DigitCount = CalculateDigitCount(text);
        stats.MarkCount = CalculateMarkCount(text);
        stats.UniqueWord = CalculateUniqueWord(text);
        stats.AverageCountWordPerSentence = CalculateAverageCountWordPerSentence(text);
        stats.LongestSentence = SearchLongestSentence(text);
        stats.LongestWord = SearchLongestWord(text);
        stats.ShortestWord = SearchShortestWord(text);
        return stats;
    }
}