using CustomList;

namespace CustomListTest;

[TestClass]
public class AddTest
{
    [TestMethod]
    public void AddToCount_IncreaseCount_CountIncreasedByOne()
    {
        // Arrange
        CustomList<string> list = new CustomList<string>();
        
        // Act
        list.Add(count++);
        // Assert
        Assert.AreEqual(1, List.count);
    }
}
