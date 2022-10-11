public class WordList : Word
{
    public string Name { get; }
    public string[] Languages { get; }

    public WordList(string name, params string[] languages)
    {
        Name = name;
        Languages = languages;
    }
    public static string[] GetLists()
    {
        string[] lista = new string[1];
        return lista;
    }
    public static WordList LoadList(string name)
    {
        WordList list = new WordList(name, "Svenska");
        return list;
    }
    public void Save()
    {

    }
    public void Add(params string[] translations)
    {

    }
    public bool Remove(int translation, string word)
    {
        return false;
    }

    public int Count()
    {
        int count = 0;
        return count;
    }
    public void List(int sortByTranslation, Action<string[]> showTranslations)
    {

    }

    public  Word GetWordToPractice()
    {
        Word word = new Word();
        return word;
    }

}

