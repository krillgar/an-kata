namespace Kata.NumberFinder;

public class SubtractHandler : BaseHandler
{
    public SubtractHandler() : base('-')
    {
    }

    protected override Func<int, int, string> Pos1Operation => Add;
    protected override Func<int, int, string> Pos2Operation => Subtract;
    protected override Func<int, int, string> Pos3Operation => Subtract;
}