using Shouldly;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1,5,3, 'A')]
    [TestCase(2,5,3, 'B')]
    [TestCase(3,5,3, 'C')]
    public void Test1(int currentRow, int lengthOfTheLine, int size, char expectedCharacter)
    {
        DiamondKata.GetCurrentLineCharacter(currentRow, lengthOfTheLine, size).ShouldBe(expectedCharacter);
    }
}