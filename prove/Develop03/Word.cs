public class Word
{
    private string _value;
    public bool IsHidden { get; private set; }

    public Word(string value)
    {
        _value = value;
        IsHidden = false;
    }

    public void Hide_Value()
    {
        IsHidden = true;
    }

    public string show_Value()
    {
        return IsHidden ? "____" : _value;
    }
}
