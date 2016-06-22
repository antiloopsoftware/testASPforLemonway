using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// Summary description for LemonWayWebServiceTest
/// </summary>
[TestClass]
public class LemonWayWebServiceTest
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void fibonacciNegativeInputShouldThrowArgumentOutOfRange()
    {
        const int FACTOR = -3;
        const int EXPECTED = -1;

        LemonWayWebService lemonWayWebService = new LemonWayWebService();

        int actual = lemonWayWebService.getFibonacci(FACTOR);
        Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void fibonacciZeroAsInputShouldThrowArgumentOutOfRange()
    {
        const int FACTOR = 0;
        const int EXPECTED = -1;

        LemonWayWebService lemonWayWebService = new LemonWayWebService();

        int actual = lemonWayWebService.getFibonacci(FACTOR);
        Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void fibonacciMoreThanHundredAsInputShouldThrowArgumentOutOfRange()
    {
        const int FACTOR = 104;
        const int EXPECTED = -1;

        LemonWayWebService lemonWayWebService = new LemonWayWebService();

        int actual = lemonWayWebService.getFibonacci(FACTOR);
        Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void fibonacciTest()
    {
        const int FACTOR = 8;
        const int EXPECTED = 21;

        LemonWayWebService lemonWayWebService = new LemonWayWebService();

        int actual = lemonWayWebService.getFibonacci(FACTOR);
        Assert.AreEqual(EXPECTED, actual, "Wrong result from Finobacci function");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void badXmlToJsonShouldThrowArgumentOutOfRange()
    {
        const string FACTOR = "<foo>hello</bar>";
        const string EXPECTED = "Bad Xml format";

        LemonWayWebService lemonWayWebService = new LemonWayWebService();

        string actual = lemonWayWebService.XmlToJson(FACTOR);
        Assert.AreEqual(EXPECTED, actual, "Wrong result from XmlToJson function");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void xmlToJsonTest()
    {
        const string FACTOR = "<foo>bar</foo>";
        const string EXPECTED = "{\"foo\":\"bar\"}";

        LemonWayWebService lemonWayWebService = new LemonWayWebService();

        string actual = lemonWayWebService.XmlToJson(FACTOR);
        Assert.AreEqual(EXPECTED, actual, "Wrong result from XmlToJson function");
    }
}