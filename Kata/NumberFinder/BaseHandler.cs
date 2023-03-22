using System.Linq;

namespace Kata.NumberFinder;

public abstract class BaseHandler
{
    private readonly char _symbol;

    protected BaseHandler(char symbol)
    {
        _symbol = symbol;
    }
    
    protected abstract Func<int, int, string> Pos1Operation { get; }
    protected abstract Func<int, int, string> Pos2Operation { get; }
    protected abstract Func<int, int, string> Pos3Operation { get; }

    public int Solve(string problem)
    {
        var (one, two, three) = Split(problem);
        string answer, result;

        if (one.IndexOf('x') > -1)
        {
            answer = one;
            result = Pos1Operation(int.Parse(three), int.Parse(two));
        }
        else if (two.IndexOf('x') > -1)
        {
            answer = two;
            result = Pos2Operation(int.Parse(one), int.Parse(three));
        }
        else
        {
            answer = three;
            result = Pos3Operation(int.Parse(one), int.Parse(two));
        }

        return int.Parse(result[answer.IndexOf('x')].ToString());
    }

    private (string one, string two, string three) Split(string problem)
    {
        var split = problem.Split('=');
        var left = split[0].Split(_symbol);
        var right = split[1].Split(_symbol);

        return left.Length == 2
            ? (left[0].Trim(), left[1].Trim(), right[0].Trim())
            : (left[0].Trim(), right[0].Trim(), right[1].Trim());
    }

    protected string Add(int one, int two)
    {
        return (one + two).ToString();
    }

    protected string Subtract(int one, int two)
    {
        return (one - two).ToString();
    }

    protected string Multiply(int one, int two)
    {
        return (one * two).ToString();
    }

    protected string Divide(int one, int two)
    {
        if (two == 0)
        {
            throw new DivideByZeroException();
        }

        return (one / two).ToString();
    }
}