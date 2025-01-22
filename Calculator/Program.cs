namespace UnitSamples;
public class Calculator
{
    static void Main()
    {
        Console.WriteLine("Hello");
    }
    public int Additional(int a, int b)
    {
        return a + b;
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }

    public int Miltiplication(int a, int b)
    {
        return a * b;
    }

    public int Division(int a, int b)
    {
        return a / b;
    }

    public int GetInputNum(string input)
    {
        int num = 0;
        if (int.TryParse(input, out num))
        {
            return num;
        }
        else
        {
            throw new System.FormatException("");
        }
    }
}