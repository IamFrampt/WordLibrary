using System.IO;

string userInput = string.Empty;
List<string> userInputSeparated = new List<string>();
bool validString = false;
Action? WhatToDo = null;

do
{
    Console.WriteLine("What do you want to do?");
    userInput = Console.ReadLine().ToLower();
    try
    {
        WhatToDo = whattodo(userInput);
    }
    catch
    {
        Console.WriteLine("Use any of the following parameters: \r\n-lists \r\n-new <list name> <language 1> <language 2> .. <langauge n> \r\n-add <list name> \r\n-remove <list name> <language> <word 1> <word 2> .. <word n> \r\n-words <listname> <sortByLanguage> \r\n-count <listname> \r\n-practice <listname> ");
    }


} while (WhatToDo == null);
Console.Clear();

WhatToDo();

Action whattodo(string userInput)
{
    List<string> userInputSeparated = new List<string>();
    userInputSeparated = userInput.Split(" ").ToList();

    validString = true;
    return (userInputSeparated[0]) switch
    {
        "-lists" => new Action(() => AllLists()),
        "-new" => new Action(() => CreateNewList()),
        "-add" => new Action(() => AddWordsToList()),
        "-remove" => new Action(() => RemoveWordsFromList()),
        "-words" => new Action(() => ViewWordsInList()),
        "-count" => new Action(() => CountWordsInList()),
        "-practice" => new Action(() => ParticeWords()),
        _ => throw new Exception("BATMAN"),
    };
}


void AllLists()
{
    Console.WriteLine("All lists: \n");
    string localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
    string pathToTranslationsFolder = Path.Combine(localAppDataFolder, "Translations");
    var filesInFolder = Directory.GetFiles(pathToTranslationsFolder);

    List<string> OnlyFileName = new List<string>();
    foreach (var f in filesInFolder)
    {
        string[] FilePath = new string[6];
        FilePath = f.Split("\\");
        OnlyFileName.Add(FilePath[6].Substring(0, FilePath[6].Length-4));
    }

    for (int i = 0; i < OnlyFileName.Count; i++)
    {
        Console.WriteLine($"{i+1}. {OnlyFileName[i]}");
    }
}
void CreateNewList()
{

}
void AddWordsToList()
{

}
void RemoveWordsFromList()
{

}

void ViewWordsInList()
{

}
void CountWordsInList()
{

}
void ParticeWords()
{

}
