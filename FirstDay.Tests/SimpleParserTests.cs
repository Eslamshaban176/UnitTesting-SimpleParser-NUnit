using NUnit.Framework;

namespace FirstDay.Tests;
[TestFixture]
public class SimpleParserTests
{
    [Test]
    public void ParseAndSum_EmptyString_ReturnsZero()
    {
        var parser = new SimpleParser();
        var result = parser.ParseAndSum("");
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void ParseAndSum_SingleNumber_ReturnsNumber()
    {
        var parser = new SimpleParser();
        var result = parser.ParseAndSum("12");
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void ParseAndSum_MultipleNumbers_ThrowsInvalidOperation()
    {
        var parser = new SimpleParser();
        Assert.That(() => parser.ParseAndSum("1,2") ,Throws.TypeOf<InvalidOperationException>());
    }

    [Test]
    public void NoRepeat_RemovesAllTargetChars()
    {
        var parser = new SimpleParser();
        var result = parser.NoRepeat("banana", 'a');
        Assert.That(result, Is.EqualTo("bnn"));
    }
    
    [Test]
    public void NoRepeat_EmptyInput_ReturnsEmpty()
    {
        var parser = new SimpleParser();
        var result = parser.NoRepeat("", 'x');
        Assert.That(result, Is.EqualTo(string.Empty));
    }
    
    [Test]
    public void NoRepeat_CharNotFound_ReturnsOriginal()
    {
        var parser = new SimpleParser();
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
        var parser = new SimpleParser();
        bool result = parser.IsPrime(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(1)]
    [TestCase(-14)]
    [TestCase(100000001)]
    public void IsPrime_InvalidInputs_ThrowsException(int input)
    {
        var parser = new SimpleParser();
        Assert.Throws<ArgumentOutOfRangeException>(() => parser.IsPrime(input));
    }
}