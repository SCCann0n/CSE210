public class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return top;
    }

    public int GetBottom()
    {
        return bottom;
    }

    public int SetTop()
    {
        _top = top;
    }
    
    public int SetBottom()
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalString()
    {
        return (double)_top / _bottom;
    }
}