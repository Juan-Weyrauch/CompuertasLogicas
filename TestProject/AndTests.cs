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
        // Arrange
        var input = new List<bool> { true, true };

        // Act
        var result = _and.Funcion(input);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}