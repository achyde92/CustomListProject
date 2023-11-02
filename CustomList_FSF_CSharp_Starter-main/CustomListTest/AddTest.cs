using CustomList;

namespace CustomListTest;

[TestClass]
public class AddTest
{
    [TestMethod]
    public void AddToCount_IncreaseCount_CountIncreasedByOne()
    {
        // Arrange
        CustomList list = new CustomList();
        // Act
        
        // Assert
        Assert.AreEqual(1, CustomList.count);
    }
}
