using System.Collections.Generic;
using EditModeTests.Mocks;
using NSubstitute;
using NUnit.Framework;
using TradeGameNamespace.Items;
using TradeGameNamespace.Items.ItemCategories;
using TradeGameNamespace.Items.ItemConditions;

namespace EditModeTests
{
    public class ItemTests
    {
        [Test]
        public void Item_GivenItemDefinition_ShouldInitializeCorrectly()
        {
            // Arrange
            var itemDefinition = Substitute.For<IItemDefinition>();
            itemDefinition.Name.Returns("Test Item");
            itemDefinition.BaseValue.Returns(100f);
            itemDefinition.Weight.Returns(1.5f);
            itemDefinition.Description.Returns("This is a test item.");
            itemDefinition.Categories.Returns(new List<IItemCategory>());
        
            // Act
            var item = new Item(itemDefinition);
            var actualName = item.Definition.Name;
            var actualValue = item.Definition.BaseValue;
            var actualWeight = item.Definition.Weight;
            var actualDescription = item.Definition.Description;
        
            // Assert
            Assert.AreEqual("Test Item", actualName);
            Assert.AreEqual(100f, actualValue);
            Assert.AreEqual(1.5f, actualWeight);
            Assert.AreEqual("This is a test item.", actualDescription);
        }
    
        [Test]
        public void ItemDefinition_Equality_ShouldReturnForSameName()
        {
            // Arrange
            var itemDefinition1 = new ItemDefinition("Test Item");
            var itemDefinition2 = new ItemDefinition("Test Item");
        
            // Act
            bool areEqual = itemDefinition1.Equals(itemDefinition2);
        
            // Assert
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void ItemDefinition_Equality_ShouldReturnFalseForDifferentName() {
            // Arrange
            var itemDefinition1 = new ItemDefinition("Test Item 1");
            var itemDefinition2 = new ItemDefinition("Test Item 2");

            // Act
            bool areEqual = itemDefinition1.Equals(itemDefinition2);

            // Assert
            Assert.IsFalse(areEqual);
        }
    
        [Test]
        public void AddCondition_ShouldAddConditionSuccessfully()
        {
            // Arrange
            var item = new Item(Substitute.For<IItemDefinition>());
            var condition = Substitute.For<IItemCondition>();
        
            // Act
            item.AddCondition(condition);
        
            // Assert
            Assert.IsTrue(item.HasCondition<IItemCondition>());
        }
    
        [Test]
        public void AddCondition_GivenNullCondition_ShouldThrowArgumentNullException()
        {
            // Arrange
            var item = new Item(Substitute.For<IItemDefinition>());
        
            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => item.AddCondition(null));
        }
    
        [Test]
        public void AddCondition_GivenExistingCondition_ShouldThrowInvalidOperationException()
        {
            // Arrange
            var item = new Item(Substitute.For<IItemDefinition>());
            var condition = Substitute.For<IItemCondition>();
            item.AddCondition(condition);
        
            // Act & Assert
            Assert.Throws<System.InvalidOperationException>(() => item.AddCondition(condition));
        }
    
        [Test]
        public void RemoveCondition_GivenPresentCondition_ShouldRemoveConditionSuccessfully()
        {
            // Arrange
            var item = new Item(Substitute.For<IItemDefinition>());
            var condition = Substitute.For<IItemCondition>();
            item.AddCondition(condition);
        
            // Act
            item.RemoveCondition(condition);
        
            // Assert
            Assert.IsFalse(item.HasCondition<IItemCondition>());
        }

        [Test]
        public void HasCondition_GivenConditionExists_ShouldReturnTrue() {
            // Arrange
            var item = new Item(Substitute.For<IItemDefinition>());
            var condition = new MockItemCondition("Test Condition", 0.1f);
            item.AddCondition(condition);
        
            // Act
            var hasCondition = item.HasCondition<MockItemCondition>();
        
            // Assert
            Assert.IsTrue(hasCondition);
        }
    
        [Test]
        public void HasCondition_GivenConditionDoesNotExist_ShouldReturnFalse() {
            // Arrange
            var item = new Item(Substitute.For<IItemDefinition>());
        
            // Act
            var hasCondition = item.HasCondition<MockItemCondition>();
        
            // Assert
            Assert.IsFalse(hasCondition);
        }
    
        [Test]
        public void HasCondition_GivenOtherConditionType_ShouldReturnFalse() {
            // Arrange
            var item = new Item(Substitute.For<IItemDefinition>());
            var condition = new MockItemCondition("Test Condition", 0.1f);
            item.AddCondition(condition);
        
            // Act
            var hasOtherCondition = item.HasCondition<MockItemConditionOther>();
            var hasCondition = item.HasCondition<MockItemCondition>();
        
            // Assert
            Assert.IsTrue(hasCondition);
            Assert.IsFalse(hasOtherCondition);
        }
    
        [Test]
        public void GetCondition_GivenConditionExists_ShouldReturnCondition() {
            // Arrange
            var item = new Item(Substitute.For<IItemDefinition>());
            var condition = new MockItemCondition("Test Condition", 0.1f);
            item.AddCondition(condition);
        
            // Act
            var retrievedCondition = item.GetCondition<MockItemCondition>();
        
            // Assert
            Assert.IsNotNull(retrievedCondition);
            Assert.AreEqual("Test Condition", retrievedCondition.Name);
        }
    }
}
