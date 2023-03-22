namespace Kata.NumberFinder;

public class DivideHandler : BaseHandler
{
    public DivideHandler() : base('/')
    {
    }

    protected override Func<int, int, string> Pos1Operation => Multiply;
    protected override Func<int, int, string> Pos2Operation => Divide;
    protected override Func<int, int, string> Pos3Operation => Divide;
}