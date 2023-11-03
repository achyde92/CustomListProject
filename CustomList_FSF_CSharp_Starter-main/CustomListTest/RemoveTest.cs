using CustomList;


namespace CustomListTest
{
	[TestClass]
	public class RemoveTest
	{
		[TestMethod]
		public void RemoveFromCount_DecreaseCount_CountDecreasedByOne()
		{
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string itemToRemove = "Thing";
            // Act
            list.Remove(itemToRemove);
            // Assert
            Assert.AreEqual(1, list.count);
        }
        [TestMethod]
        public void Remove_ReturnTrue_ItemSuccessfullyRemoved()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string itemToRemove = "Thing";
            // Act
            list.Remove(itemToRemove);
            // Assert
            Assert.AreEqual(true, list.Remove);
        }
        [TestMethod]
        public void Remove_ItemNotInCustomList_CountStaysTheSame()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string itemToRemove = "Thing";
            // Act
            list.Remove(itemToRemove);
            // Assert
            Assert.AreEqual(1, list.count);
        }
        [TestMethod]
        public void RemoveFromCount_()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string itemToRemove = "Thing";
            // Act
            list.Remove(itemToRemove);
            // Assert
            Assert.AreEqual(1, list.count);
        }
        [TestMethod]
        public void RemoveFromCount_()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string itemToRemove = "Thing";
            // Act
            list.Remove(itemToRemove);
            // Assert
            Assert.AreEqual(1, list.count);
        }
    }
}

