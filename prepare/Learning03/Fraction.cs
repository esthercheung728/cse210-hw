using System;
using System.Numerics;
public class Fraction

{
    private int _top;
    private int _botton;

    public Fraction()
    {
        _top = 1;
        _botton = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _botton = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _botton = bottom;
    }

    public string GetFractionString()
    {

        string amount = $"{_top}/{_botton}";
        return amount;
    }

    public double GetDecimalValue()
    {

        return (double)_top / _botton;
    }

}