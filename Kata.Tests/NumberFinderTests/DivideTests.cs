using Kata.NumberFinder;

namespace Kata.Tests.NumberFinderTests;

public class DivideTests
{
    private readonly NumberSolver _solver;
    
    public DivideTests()
    {
        _solver = new NumberSolver();
    }
    
    [Fact]
    public void CanPerformSimpleDivision()
    {
        var result = _solver.Process("8 / 2 = x");

        Assert.Equal(4, result);
    }

    [Fact]
    public void CanPerformDivisionWithXInPositionOne()
    {
        var result = _solver.Process("x / 3 = 3");

        Assert.Equal(9, result);
    }

    [Fact]
    public void CanPerformDivisionWithXInPositionTwo()
    {
        var result = _solver.Process("4 / x = 4");

        Assert.Equal(1, result);
    }

    [Fact]
    public void CanSolve_WithXInMiddleOfNumber()
    {
        var result = _solver.Process("1x64 / 16 = 79");

        Assert.Equal(2, result);
    }
}