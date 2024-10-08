using System;
using Library; 
namespace TestProject;

[TestFixture]
public class NotTests
{
    private Not _or;

    [SetUp]

    public void Setup()
    {
        _or = new Not();
    }

    [Test]
    public void If_False_Return_True()
    {
        bool input = false;
        bool expected = _or.Funcion(input);
        
        Assert.IsTrue(expected);
    }

    [Test]
    public void If_True_Return_False()
    {
        bool input = true;
        bool expected = _or.Funcion(input);
        
        Assert.IsFalse(expected);
    }
}