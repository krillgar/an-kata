using Kata.NumberFinder;

namespace Kata.Tests.NumberFinderTests;

public class SubtractTests
{
    private readonly NumberSolver _solver;
    
    public SubtractTests()
    {
        _solver = new NumberSolver();
    }
    
    [Fact]
    public void CanPerformSimpleSubtraction()
    {
        var result = _solver.Process("7 - 2 = x");

        Assert.Equal(5, result);
    }

    [Fact]
    public void CanPerformSubtractionWithXInPositionOne()
    {
        var result = _solver.Process("x - 4 = 5");

        Assert.Equal(9, result);
    }

    [Fact]
    public void CanPerformSubtractionWithXInPositionTwo()
    {
        var result = _solver.Process("3 - x = 1");

        Assert.Equal(2, result);
    }

    [Fact]
    public void CanSolve_WithXInMiddleOfNumber()
    {
        var result = _solver.Process("2386 - 1x24 = 762");

        Assert.Equal(6, result);
    }
}