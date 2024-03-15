using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetFormattedReference()
    {
        return $"{_book} {_chapter}:{_startVerse}";
    }

    public static Reference Parse(string referenceString)
    {
        // Split into 2 parts
        string[] parts = referenceString.Split('|');
        // Reference parsing code
        if (parts.Length == 2)
        {
            string referencePart = parts[0].Trim();
            string textPart = parts[1].Trim();

            string[] referenceParts = referencePart.Split(' ');

            // Use , to split 
            if (referenceParts.Length >= 3)
            {
                // Reference 1
                string book = referenceParts[0];
                int chapter = int.Parse(referenceParts[1]);
                string[] verseParts = referenceParts[2].Split('-');
                int startVerse = int.Parse(verseParts[0]);
                int endVerse = startVerse;
                if (verseParts.Length > 1)
                {
                    endVerse = int.Parse(verseParts[1]);
                }
                // Reference 2
                return new Reference(book, chapter, startVerse, endVerse);
            }
        }
        // Show msg if not met format
        throw new ArgumentException("Invalid reference format.");
    }
}