using System;
using Library; 

namespace TestProject;

[TestFixture]

public class AndTests
{
    private And _and;
    
    [SetUp]
    public void Setup()
    {
        _and = new And();
    }

    [Test]
    public void If_Both_True_Then_Return_True()
    {
        List<bool> input = new List<bool> { true, true };

        bool result = _and.Funcion(input);

        Assert.IsTrue(result);
    }

    [Test]
    public void Funcion_OneFalse_ReturnsFalse()
    {
        List<bool> input = new List<bool> { true, false };

        bool result = _and.Funcion(input);

        Assert.IsFalse(result);
    }

    [Test]
    public void Funcion_BothFalse_ReturnsFalse()
    {
        List<bool> input = new List<bool> { false, false };

        bool result = _and.Funcion(input);

        Assert.IsFalse(result);
    }

    [Test]
    public void Funcion_OnlyUsesFirstTwoElements()
    {
        List<bool> input = new List<bool> { true, false, false };

        bool result = _and.Funcion(input);

        Assert.IsFalse(result);
    }

    [Test]
    public void Funcion_EmptyList_OutOfRange()
    {
        List<bool> input = new List<bool>();

        Assert.Throws<System.ArgumentOutOfRangeException>(() => _and.Funcion(input));
        
        // using _and.Funcion(input) we expect to show the exception System.ArgumentOutOfRange ggs
    }
}