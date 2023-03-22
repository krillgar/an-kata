namespace Kata.NumberFinder;

public class AddHandler : BaseHandler
{
    public AddHandler() : base('+')
    {
    }

    protected override Func<int, int, string> Pos1Operation => Subtract;
    protected override Func<int, int, string> Pos2Operation => (one, two) => Subtract(two, one);
    protected override Func<int, int, string> Pos3Operation => Add;
}