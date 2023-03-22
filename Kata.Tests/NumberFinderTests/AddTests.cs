using Kata.NumberFinder;

namespace Kata.Tests.NumberFinderTests;

public class AddTests
{
    private readonly NumberSolver _solver;
    
    public AddTests()
    {
        _solver = new NumberSolver();
    }
    
    [Fact]
    public void CanPerformSimpleAddition()
    {
        var result = _solver.Process("3 + 2 = x");

        Assert.Equal(5, result);
    }

    [Fact]
    public void CanPerformAdditionWithXInPositionOne()
    {
        var result = _solver.Process("x + 2 = 5");

        Assert.Equal(3, result);
    }

    [Fact]
    public void CanPerformAdditionWithXInPositionTwo()
    {
        var result = _solver.Process("3 + x = 5");

        Assert.Equal(2, result);
    }

    [Fact]
    public void CanSolve_WithXInMiddleOfNumber()
    {
        var result = _solver.Process("14x3 + 275 = 1768");

        Assert.Equal(9, result);
    }
}