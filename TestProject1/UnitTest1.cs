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
    [TestCase(1,1,1, 'A')]
    [TestCase(2,5,3, 'B')]
    [TestCase(3,5,3, 'C')]
    public void GetCurrentLineCharacter_ShouldReturnCorrectCharacterForLineAndSize(int currentRow, int lengthOfTheLine, int size, char expectedCharacter)
    {
        DiamondKata.GetCurrentLineCharacter(currentRow, lengthOfTheLine, size).ShouldBe(expectedCharacter);
    }

    [Test]
    [TestCase(1,1,1, "A")]
    [TestCase(1,3,2, "-A-")]
    [TestCase(2,3,2, "B-B")]
    [TestCase(3,3,2, "-A-")]
    public void GetLineForIndex(int currentRow, int lengthOfTheLine, int size, string expected)
    {
        DiamondKata.GetLineForIndex(currentRow, lengthOfTheLine, size).ShouldBe(expected);
    }
}