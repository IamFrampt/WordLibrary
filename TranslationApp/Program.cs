using System.Text;
string defaultString = "Use any of the following parameters: " +
    "\r\n-lists " +
    "\r\n-new <list name> <language 1> <language 2> .. <langauge n> " +
    "\r\n-add <list name> " +
    "\r\n-remove <list name> <language> <word 1> <word 2> .. <word n> " +
    "\r\n-words <listname> <sortByLanguage> " +
    "\r\n-count <listname> " +
    "\r\n-practice <listname>";

string path = String.Empty;

string dir = WordList.pathToFolder;

if (!Directory.Exists(dir))
{
    Directory.CreateDirectory(dir);
}

if(args.Length ==0)
{
    Console.WriteLine(defaultString);
    args = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
}

whatMethodToRun(args);

//Methods

void whatMethodToRun(string[] args)
{
    switch (args[0])
    {
        case "-lists":

            Console.Clear();

            if (args.Length == 1)
            {
                ShowListsInFolder();
            }
            else
            {
                Console.WriteLine(defaultString);
            }
            break;

        case "-new":
            Console.Clear();

            if (args.Length >= 4)
            {
                CreateNewFile(args);
                AddWords(args);
            }
            else
            {
                Console.WriteLine(defaultString);
            }
            break;

        case "-add":

            Console.Clear();
            if (args.Length < 2 || args.Length > 2)
            {
                Console.WriteLine(defaultString);
            }
            else if (args.Length == 2)
            {
                AddWords(args);
            }

            break;

        case "-remove":

            Console.Clear();
            if (args.Length >= 4)
            {
                RemoveWord(args);
            }
            else
            {
                Console.WriteLine(defaultString);
            }
            break;

        case "-words":
            Console.Clear();
            if (args.Length >= 2 || args.Length <= 3)
            {
                try
                {
                    ShowWords(args);
                }
                catch
                {
                    Console.WriteLine($"Could not find file with the name {args[1]}.dat");
                }
            }
            else
            {
                Console.WriteLine(defaultString);
            }
            break;

        case "-count":

            Console.Clear();
            if (args.Length <= 2)
            {
                try
                {
                    WordList CountList = WordList.LoadList(args[1]);
                    Console.WriteLine($"{(CountList.Count() > 1 ? $"There are {CountList.Count()} words" : $"There is {CountList.Count()} word")} in the list \"{args[1]}\"");
                }
                catch
                {
                    Console.WriteLine($"Could not find file with the name {args[1]}.dat");
                }
            }
            else
            {
                Console.WriteLine(defaultString);
            }
            break;

        case "-practice":

            Console.Clear();
            if (args.Length == 2)
            {
                try
                {
                    PracticeWords(args);
                }
                catch
                {
                    Console.WriteLine($"Could not find file with the name {args[1]}.dat");
                }
            }
            else
            {
                Console.WriteLine(defaultString);
            }
            break;
        case "-exit":
            break;

        default:
            Console.Clear();
            Console.WriteLine(defaultString);
            break;
    }
}

void ShowListsInFolder()
{
    Console.WriteLine("Lists:");
    foreach (var listName in WordList.GetLists()) { Console.WriteLine($"{listName}"); }
}

void CreateNewFile(string[] userInput)
{
    string path = (Path.Combine(WordList.pathToFolder, userInput[1].ToString() + ".dat"));

    if (!File.Exists(path))
    {
        fileCreate(path, userInput);
        Console.WriteLine("New file created.");
    }
    else
    {
        Console.WriteLine("File already exist with that name you want to overwrite it? Y or N");
        string YesOrNo = Console.ReadLine().ToLower();

        if (YesOrNo == "y")
        {
            fileCreate(path, userInput);
            Console.WriteLine("File was overwritten.");
        }
        else
        {
            Console.WriteLine("File was not overwritten.");
        }
    }
}

void fileCreate(string path, string[] userInput)
{
    using (FileStream fs = File.Create(path))
    {
        byte[] bufferLanguage = new UTF8Encoding(true).GetBytes($"{string.Join(";", userInput.Skip(2))};");
        fs.Write(bufferLanguage, 0, bufferLanguage.Length);
    }
}

void AddWords(string[] userInput)
{
    WordList? addWord = null;
    string? newWord = string.Empty;
    int languageCounter = 0;
    List<string> newWords = new List<string>();
    int wordCounter = 0;

    try
    {
        addWord = WordList.LoadList(userInput[1]);
    }
    catch
    {
        addWord = null;
        Console.WriteLine($"Could not find file with the name {args[1]}.dat");
    }

    if (addWord != null)
    {

        wordCounter = addWord.Count();

        do
        {
            if (newWord != "")
            {
                newWords.Add(newWord);
            }
            if (languageCounter == addWord.Languages.Length)
                languageCounter = 0;

            Console.Write($"Word in {addWord.Languages[languageCounter]}: ");
            newWord = Console.ReadLine();
            languageCounter++;

        } while (newWord != "");


        addWord.Add(newWords.ToArray());
        DidUserAddWords(addWord, wordCounter);
    }
}

void DidUserAddWords(WordList _wordlist, int wordCount)
{
    if (_wordlist.Count() > wordCount)
    {
        _wordlist.Save();
        Console.WriteLine("New words added. Save was successful.");
    }
    else
    {
        Console.WriteLine("No new words was added to the list. You might have tried to add a word that already exists in the list.");
    }
}

void RemoveWord(string[] userInput)
{
    WordList? removeWord = null;

    try
    {
        removeWord = WordList.LoadList(userInput[1]);
    }
    catch
    {
        removeWord = null;
        Console.WriteLine($"Could not find file with the name {args[1]}.dat");
    }

    if (removeWord != null)
    {

        int selectedLanguage = SelectedLanguage(removeWord, userInput);
        if (selectedLanguage >= 0)
        {

            for (int i = 3; i < args.Length; i++)
            {
                if (removeWord.Remove(selectedLanguage, args[i]))
                {
                    Console.WriteLine($"{args[i]} deleted from file.");
                    removeWord.Save();
                }
                else
                {
                    Console.WriteLine($"{args[i]} doesn't exist in the list and could not be deleted.");
                }
            }
        }
        else
        {
            Console.WriteLine("The selected language doesn't exist in the file.");
        }
    }
}

int SelectedLanguage(WordList _wordList, string[] userinput)
{
    for (int i = 0; i < _wordList.Languages.Length; i++)
    {
        if (args[2] == _wordList.Languages[i])
            return i;
    }
    return -1;
}

void ShowWords(string[] userInput)
{
    WordList showWords = WordList.LoadList(args[1]);
    int selectedLanguage = -1;


    if (args.Length > 2)
    {
        selectedLanguage = SelectedLanguage(showWords, userInput);
    }
    else
    {
        selectedLanguage = 0;
    }

    if (selectedLanguage >= 0)
    {

        for (int i = 0; i < showWords.Languages.Length; i++)
        {
            Console.Write(showWords.Languages[i].PadRight(10).ToUpper());

        }
        Console.WriteLine();
        showWords.List(selectedLanguage, PrintWordsInList);
    }
    else
    {
        Console.WriteLine("The selected language doesn't exist in the file.");
    }
}

void PrintWordsInList(string[] translations)
{
    foreach (string currentstring in translations)
    {
        Console.Write(currentstring.PadRight(10));
    }
    Console.WriteLine();
}

void PracticeWords(string[] userInput)
{
    int correctAnswers = 0;
    int totalPracticeWords = 0;
    double correctAnswersInProcent = 0.0;
    string input = string.Empty;
    WordList pWord = WordList.LoadList(userInput[1]);

    do
    {
        Word newPracticeWord = pWord.GetWordToPractice();
        Console.WriteLine($"Translate the word \"{newPracticeWord}\" to {pWord.Languages[newPracticeWord.ToLanguage]}");

        input = Console.ReadLine().ToLower();

        if (input == newPracticeWord.Translations[1])
        {
            Console.WriteLine("Correct!\n");
            correctAnswers++;
            totalPracticeWords++;
        }

        if (input != newPracticeWord.Translations[1] && input != "")
        {
            Console.WriteLine("Wrong!\n");
            totalPracticeWords++;
        }

    } while (input != "");

    correctAnswersInProcent = Math.Round(((double)correctAnswers / (double)totalPracticeWords) * 100, 1);
    Console.WriteLine($"\nYou got {correctAnswers} correct answers out of {totalPracticeWords}. That's {correctAnswersInProcent}%");
}
