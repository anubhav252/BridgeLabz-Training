using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

[TestClass]
public class CalculatorTests
{
    private Calculator calc;

    [TestInitialize]
    public void Setup()
    {
        calc = new Calculator();
    }

    [TestMethod]
    public void Test_Add()
    {
        int result = calc.Add(10, 5);
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void Test_Subtract()
    {
        int result = calc.Subtract(10, 5);
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Test_Multiply()
    {
        int result = calc.Multiply(10, 5);
        Assert.AreEqual(50, result);
    }

    [TestMethod]
    public void Test_Divide()
    {
        int result = calc.Divide(10, 5);
        Assert.AreEqual(2, result);
    }
}
