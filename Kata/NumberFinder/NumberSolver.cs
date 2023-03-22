namespace Kata.NumberFinder;

public class NumberSolver
{
    public int Process(string problem)
    {
        var handler = GetHandler(problem);
        
        return handler.Solve(problem);
    }

    private BaseHandler GetHandler(string problem)
    {
        if (problem.IndexOf('+') > -1)
        {
            return new AddHandler();
        }

        if (problem.IndexOf('-') > -1)
        {
            return new SubtractHandler();
        }

        if (problem.IndexOf('*') > -1)
        {
            return new MultiplyHandler();
        }

        if (problem.IndexOf('/') > -1)
        {
            return new DivideHandler();
        }

        throw new InvalidOperationException($"\"{problem}\" does not include a mathematical symbol.");
    }
}