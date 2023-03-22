using Kata.NumberFinder;

namespace Kata.Tests.NumberFinderTests;

public class MultiplyTests
{
    private readonly NumberSolver _solver;
    
    public MultiplyTests()
    {
        _solver = new NumberSolver();
    }
    
    [Fact]
    public void CanPerformSimpleMultiplication()
    {
        var result = _solver.Process("3 * 2 = x");

        Assert.Equal(6, result);
    }

    [Fact]
    public void CanPerformMultiplicationWithXInPositionOne()
    {
        var result = _solver.Process("x * 2 = 10");

        Assert.Equal(5, result);
    }

    [Fact]
    public void CanPerformMultiplicationWithXInPositionTwo()
    {
        var result = _solver.Process("3 * x = 27");

        Assert.Equal(9, result);
    }

    [Fact]
    public void CanSolve_WithXInMiddleOfNumber()
    {
        var result = _solver.Process("1x3 * 275 = 44825");

        Assert.Equal(6, result);
    }
}