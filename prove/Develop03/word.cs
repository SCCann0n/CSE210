public class Word
{
    private string _holdWord;

    private bool _isHidden;
    public Word(string holdWord)
    {
        _holdWord = holdWord.Trim();
        _isHidden = false;
    }

    public void Hide()

    {
        if (_isHidden == false)
        {
            char[] chars = _holdWord.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = '_';
            }

            _holdWord = new string(chars);

            _isHidden = true;
        }

    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _holdWord;
    }

        
    }