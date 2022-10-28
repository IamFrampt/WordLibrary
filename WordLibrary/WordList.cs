public class WordList : Word
{
    public static string pathToFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Halloween");
    private static string? fileName = null;
    static bool fromload = false;
    static bool firstword = true;

    private List<Word> Words = new List<Word>();
    public string Name { get; }
    public string[] Languages { get; }
    public WordList(string name, params string[] languages)
    {
        Name = name;
        Languages = languages;
    }
    public static string[] GetLists()
    {
        try
        {
            var filesInFolder = Directory.GetFiles(pathToFolder);
            List<string> fileNames = new List<string>();

            for (int i = 0; i < filesInFolder.Length; i++)
            {
                if (filesInFolder[i].Contains(".dat"))
                {
                    var filename = Path.GetFileNameWithoutExtension(filesInFolder[i]);
                    fileNames.Add(filename);
                }
            }

            Array.Sort(fileNames.ToArray());

            return fileNames.ToArray();
        }
        catch
        {
            return new string[0];
        }
    }

    public static WordList LoadList(string name)
    {
        string[] nameOfLanguages;
        string[] currentLineWordsSplit;
        firstword = true;

        fileName = Path.Combine(pathToFolder, name + ".dat");

        using (var readFile = new StreamReader(fileName))
        {
            nameOfLanguages = 
                readFile.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            WordList newWordList = new WordList(name, nameOfLanguages);

            while (!readFile.EndOfStream)
            {
                fromload = true;
                var currentLine = readFile.ReadLine();
                if (currentLine != "")
                {
                    if (currentLine.Contains(';'))
                    {
                        currentLineWordsSplit = currentLine.Split(";", StringSplitOptions.RemoveEmptyEntries);
                        newWordList.Add(currentLineWordsSplit);
                        firstword = false;
                    }
                }
            }
            fromload = false;
            return newWordList;
        }
    }
    public int Count()
    {
        if (Words.Count > 0) return Words.Count;
        else return 0;
    }

    public bool Remove(int translation, string word)
    {
        string wordToLower = word.ToLower();
        for (int i = 0; i < Words.Count; i++)
        {
            if (Words[i].Translations[translation].Equals(wordToLower))
            {
                Words.RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    public void Add(params string[] translations)
    {
        if(translations.Length % Languages.Length == 0)
        {
            bool doesWordExistInList = false;
            List<string> translationsToLower = new();
            for (int i = 0; i < translations.Length; i++)
            {
                translationsToLower.Add(translations[i].Trim().ToLower());
            }

            if (fromload)
            {
                for (int i = 0; i < Words.Count; i++)
                {
                    if (Words[i].Translations[0].Equals(translations[0]))
                    {
                        doesWordExistInList = true;
                        continue;
                    }

                    if (i == Words.Count - 1 && !doesWordExistInList)
                    {
                        Word newWordAdded = new Word(translationsToLower.GetRange(0, Languages.Length).ToArray());
                        Words.Add(newWordAdded);
                    }

                }
            }
            else
            {
                for (int j = 0; j < translations.Length; j += Languages.Length)
                {
                    for (int i = 0; i < Words.Count; i++)
                    {
                        if (Words[i].Translations[0].Equals(translations[j]))
                        {
                            doesWordExistInList = true;
                            break;
                        }

                        if (i == Words.Count - 1 && !doesWordExistInList)
                        {
                            Word newWordAdded = new Word(translationsToLower.GetRange(j, Languages.Length).ToArray());
                            Words.Add(newWordAdded);
                        }

                    }
                    doesWordExistInList = false;
                }
            }

            if (firstword)
            {
                Word newWordAdded = new Word(translationsToLower.GetRange(0, Languages.Length).ToArray());
                Words.Add(newWordAdded);
            }
        }
        else
        {
            throw new ArgumentException("User didn't enter enough words.");
        }
    }

    public void Save()
    {
        string fileName = Path.Combine(pathToFolder, $"{Name}.dat");
        string allLines = string.Join(";", Languages);


        for (int i = 0; i < Words.Count; i++)
        {
            allLines += $"\n{string.Join(";", Words[i].Translations)};";
        }

        File.WriteAllText(fileName, allLines);
    }

    public void List(int sortByTranslation, Action<string[]> showTranslations)
    {
        List<Word> sorted = (from w in Words orderby w.Translations[sortByTranslation] select w).ToList();

        foreach (Word w in sorted)
        {
            showTranslations(w.Translations);
        }
    }

    public Word GetWordToPractice()
    {
        Random random = new Random();
        int wordIndex = random.Next(Words.Count);
        int fromLanguage = random.Next(Languages.Length);
        int toLanguage = random.Next(Languages.Length);

        while (fromLanguage == toLanguage)
        {
            toLanguage = random.Next(Languages.Length);
        }

        Word PraticeWord = new Word(fromLanguage, toLanguage, Words[wordIndex].Translations[fromLanguage], Words[wordIndex].Translations[toLanguage]);

        return PraticeWord;
    }
}
