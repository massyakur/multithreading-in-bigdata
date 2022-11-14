int CountWords(string s)
{
    // i assume just a space between words
    int count = s.Split(' ').Length;
    return count;
}
int CountSameWords(string source, string target)
{
    // daha az kelimesi olan cumledeki kelimeler, target icinde var mi
    int count = 0;
    string[] words = source.Split(' ');
    foreach (string word in words)
    {
        if (target.ToLower().Contains(word.ToLower()))
        {
            count++;
        }
    }
    return count;
}
double CalculateSimilarity(string str1, string str2)
{
    int str1len = CountWords(str1);
    int str2len = CountWords(str2);
    int Longest = str1len > str2len ? str1len : str2len;

    int SameWordsCount = str1len > str2len ? CountSameWords(str2, str1) : CountSameWords(str1, str2);

    double SimilarityPercent = (double)SameWordsCount / Longest;
    return SimilarityPercent;
}


Console.WriteLine(CalculateSimilarity("Credit reporting credit repair services personal consumer reports", "Payday loan title loan personal loan"));

