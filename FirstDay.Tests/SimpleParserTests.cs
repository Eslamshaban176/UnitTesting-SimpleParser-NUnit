using NUnit.Framework;

namespace FirstDay.Tests;
[TestFixture]
public class SimpleParserTests
{
    private SimpleParser parser;
    
    [SetUp]
    public void SetUp()
    {
         parser = new SimpleParser();
    }
    
    [Test]
    public void ParseAndSum_EmptyString_ReturnsZero()
    {

        var result = parser.ParseAndSum("");
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void ParseAndSum_SingleNumber_ReturnsNumber()
    {
        var result = parser.ParseAndSum("12");
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void ParseAndSum_MultipleNumbers_ThrowsInvalidOperation()
    {
        Assert.That(() => parser.ParseAndSum("1,2") ,Throws.TypeOf<InvalidOperationException>());
    }

    [Test]
    public void NoRepeat_RemovesAllTargetChars()
    {
        var result = parser.NoRepeat("banana", 'a');
        Assert.That(result, Is.EqualTo("bnn"));
    }
    
    [Test]
    public void NoRepeat_EmptyInput_ReturnsEmpty()
    {
        var result = parser.NoRepeat("", 'x');
        Assert.That(result, Is.EqualTo(string.Empty));
    }
    
    [Test]
    public void NoRepeat_CharNotFound_ReturnsOriginal()
    {
        var result = parser.NoRepeat("hello", 'z');
        Assert.That(result, Is.EqualTo("hello").IgnoreCase);
    }
    
    [TestCase(2, true)]
    [TestCase(20, false)]
    [TestCase(47, true)]
    [TestCase(933, false)]
    [TestCase(10000000, false)]
    public void IsPrime_ValidInputs_ReturnsExpected(int input, bool expected)
    {
        bool result = parser.IsPrime(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(1)]
    [TestCase(-14)]
    [TestCase(100000001)]
    public void IsPrime_InvalidInputs_ThrowsException(int input)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => parser.IsPrime(input));
    }
}