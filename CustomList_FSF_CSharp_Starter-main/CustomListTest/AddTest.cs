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
        string itemToAdd = "Thing";
        // Act
        list.Add(itemToAdd);
        // Assert
        Assert.AreEqual(1, list.count);
    }

    [TestMethod]
    public void AddToCount_IndexZero_FirstItemAddedAtIndexZero()
    {
        // Arrange
        CustomList<string> list = new CustomList<string>();
        string itemToAdd = "Thing";
        // Act
        list.Add(itemToAdd);
        // Assert
        Assert.AreEqual(list[0], "Thing");
    }

    [TestMethod]
    public void AddToCount_IndexOne_SecondItemAddedAtIndexOne()
    {
        // Arrange
        CustomList<string> list = new CustomList<string>();
        string itemToAdd = "Thing";
        // Act
        list.Add(itemToAdd);
        // Assert
        Assert.AreEqual(list[1], "Thing");
    }
    [TestMethod]
    public void AddCapacity_IncreaseCapacity_CapacityIncreases()
    {
        // Arrange
        CustomList<string> list = new CustomList<string>();
        string itemToAdd = "Thing";
        // Act
        list.Add(itemToAdd);
        // Assert
        Assert.AreEqual(, list.capacity);
    }
    [TestMethod]
    public void AddOldItemToNewArray_CarryOverItem_OldItemNewArray()
    {
        // Arrange
        CustomList<string> list = new CustomList<string>();
        string itemToAdd = "Thing";
        // Act
        list.Add(itemToAdd);
        // Assert
        Assert.AreEqual(1, list.count);
    }


}
