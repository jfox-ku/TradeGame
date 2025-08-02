using NUnit.Framework;

namespace EditModeTests
{
    public class ItemCategoryTests
    {
        [Test]
        public void TestItemCategoryCreation()
        {
            // Arrange
            var categoryName = "TestCategory";
            
            // Act
            var itemCategory = new Mocks.MockItemCategory(categoryName);
            
            // Assert
           Assert.AreEqual(categoryName, itemCategory.Name);
        }
        
        [Test]
        public void TestItemCategoryEquality()
        {
            // Arrange
            var category1 = new Mocks.MockItemCategory("CategoryA");
            var category2 = new Mocks.MockItemCategory("CategoryA");
            var category3 = new Mocks.MockItemCategory("CategoryB");
            
            // Act & Assert
            Assert.AreEqual(category1.Name, category2.Name);
            Assert.AreNotEqual(category1.Name, category3.Name);
        }
        
    }
}