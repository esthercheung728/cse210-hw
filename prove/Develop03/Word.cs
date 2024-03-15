public class Word
{

    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }

    // Check is hidden or not by using _
    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}