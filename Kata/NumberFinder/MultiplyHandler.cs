namespace Kata.NumberFinder;

public class MultiplyHandler : BaseHandler
{
    public MultiplyHandler() : base('*')
    {
    }

    protected override Func<int, int, string> Pos1Operation => Divide;
    protected override Func<int, int, string> Pos2Operation => (one, two) => Divide(two, one);
    protected override Func<int, int, string> Pos3Operation => Multiply;
}