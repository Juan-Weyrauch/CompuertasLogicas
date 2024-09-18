using Library;

namespace TestProject;

[TestFixture]
public class OrTests
{
    private Or _or;

    [SetUp]
    public void Setup()
    {
        _or = new Or();
    }

    [Test]
    public void Cero_Cero_Returns_False()
    {
        List<bool> input = new List<bool> { false, false };

        bool result = _or.Funcion(input);
        
        Assert.IsFalse(result);
    }
    
    [Test]
    public void Cero_One_Returns_True()
    {
        List<bool> input = new List<bool> { false, true };

        bool result = _or.Funcion(input);
        
        Assert.IsTrue(result);
    }
    
    [Test]
    public void One_One_Returns_True()
    {
        List<bool> input = new List<bool> { true, true };

        bool result = _or.Funcion(input);
        
        Assert.IsTrue(result);
    }

}