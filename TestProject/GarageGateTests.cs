using System;
using Library; 

namespace TestProject;

[TestFixture]

public class GarageGateTests
{
    private GarageGate _garageGate;
    
    [SetUp]
    public void Setup()
    {
        _garageGate = new GarageGate();
    }
    
    /*========================= ACA EMPIEZAN LOS VALORES DE VERDAD ===========================*/    
    [Test]
    public void If_All_True_Then_Return_True() ////////// 1 1 1
    {
        List<bool> input = new List<bool> { true, true, true };

        bool result = _garageGate.Funcion(input);

        Assert.IsTrue(result);
    }

    [Test]
    public void C_True_A_Y_B_False_Returns_True() /////////// 1 0 0  
    {
        List<bool> input = new List<bool> { false, false, true };

        bool result = _garageGate.Funcion(input);

        Assert.IsTrue(result);
    }
    
    /*========================= ACA TERMINAN LOS VALORES DE VERDAD ===========================*/

    
    
    
    [Test]
    public void If_All_False_Then_Return_False() ////////////// 0 0 0 
    {
        List<bool> input = new List<bool> { false, false, false };

        bool result = _garageGate.Funcion(input);

        Assert.IsFalse(result);
    }

    [Test]
    public void C_False_B_False_A_True_Returns_False() /////////// 0 0 1
    {
        List<bool> input = new List<bool> { true, false, false };
        bool result = _garageGate.Funcion(input);
        
        Assert.IsFalse(result);
    }

    [Test]
    public void C_False_B_True_A_False_Returns_False() ////////// 0 1 0
    {
        List<bool> input = new List<bool> { false, true, false };
        bool result = _garageGate.Funcion(input);
        Assert.IsFalse(result);
    }

    [Test]
    public void C_False_B_True_A_True_Returns_False() /////////// 0 1 1 (6)
    {
        List<bool> input = new List<bool> { true, true, false };

        bool result = _garageGate.Funcion(input);

        Assert.IsFalse(result);
    }

    [Test]
    public void C_True_B_False_A_True_Returns_False() //////////// 1 0 1(7)
    {
        List<bool> input = new List<bool> { true, false, true };
        bool result = _garageGate.Funcion(input);
        Assert.IsFalse(result);
    }
    
    [Test]
    public void C_True_B_True_A_False_Returns_False() /////////// 1 1 0
    {
        List<bool> input = new List<bool> { false, true, true };
        bool result = _garageGate.Funcion(input);
        Assert.IsFalse(result);
    }
    
    
    [Test]
    public void Funcion_EmptyList_OutOfRange()
    {
        List<bool> input = new List<bool>();

        Assert.Throws<System.ArgumentOutOfRangeException>(() => _garageGate.Funcion(input));
        
        // using _and.Funcion(input) we expect to show the exception System.ArgumentOutOfRange ggs
    }
}