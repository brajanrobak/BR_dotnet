namespace TextAnalyzer.app;

public class TextStatistics
{
    public int CharacterCount { get; set; }
    public int CharacterCountWithoutSpace { get; set; }
    public int CharacterCountWithoutSpecial { get; set; }
    public int DigitCount { get; set; }
    public int MarkCount { get; set; }
    public int WordCount { get; set; }
    public int UniqueWord { get; set; }
    public string MostCommonWord { get; set; }
    public float AverageWordLength { get; set; }
    public string LongestWord { get; set; }
    public string ShortestWord { get; set; }
    public int SentenceCount { get; set; }
    public float AverageCountWordPerSentence { get; set; }
    public string LongestSentence { get; set; }
    
    
}