using System.Linq;
using NUnit.Framework;
using TradeGameNamespace.Inventory;

namespace EditModeTests
{
    public class InventoryTests
    {
        [Test]
        public void Inventory_GivenCapacity_ShouldInitializeWithCorrectCapacity()
        {
            // Arrange
            int expectedCapacity = 10;
            var inventory = new Inventory(expectedCapacity);

            // Act
            int actualCapacity = inventory.Capacity;

            // Assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }
    
        [Test]
        public void AddElement_ShouldIncreaseElementCount()
        {
            // Arrange
            var inventory = new Inventory();
            var element = NSubstitute.Substitute.For<IInventoryElement>();
    
            // Act
            inventory.AddElement(element);
        
            // Assert
            Assert.AreEqual(1, inventory.ElementCount);
            Assert.IsTrue(inventory.ContainsElement(element));
        }
    
        [Test]
        public void AddElement_WhenFull_ShouldThrowInvalidOperationException()
        {
            // Arrange
            var inventory = new Inventory(1);
            var element1 = NSubstitute.Substitute.For<IInventoryElement>();
            var element2 = NSubstitute.Substitute.For<IInventoryElement>();
        
            inventory.AddElement(element1);
        
            // Act & Assert
            Assert.Throws<System.InvalidOperationException>(() => inventory.AddElement(element2));
        }
    
        [Test]
        public void RemoveElement_ShouldDecreaseElementCount()
        {
            // Arrange
            var inventory = new Inventory();
            var element = NSubstitute.Substitute.For<IInventoryElement>();
        
            inventory.AddElement(element);
        
            // Act
            inventory.RemoveElement(element);
        
            // Assert
            Assert.AreEqual(0, inventory.ElementCount);
            Assert.IsFalse(inventory.ContainsElement(element));
        }
    
        [Test]
        public void RemoveElement_WhenNotInInventory_ShouldThrowArgumentException()
        {
            // Arrange
            var inventory = new Inventory();
            var element = NSubstitute.Substitute.For<IInventoryElement>();
        
            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => inventory.RemoveElement(element));
        }
    
        [Test]
        public void ContainsElement_WhenElementExists_ShouldReturnTrue()
        {
            // Arrange
            var inventory = new Inventory();
            var element = NSubstitute.Substitute.For<IInventoryElement>();
        
            inventory.AddElement(element);
        
            // Act
            bool contains = inventory.ContainsElement(element);
        
            // Assert
            Assert.IsTrue(contains);
        }
    
        [Test]
        public void ContainsElement_WhenElementDoesNotExist_ShouldReturnFalse()
        {
            // Arrange
            var inventory = new Inventory();
            var element = NSubstitute.Substitute.For<IInventoryElement>();
        
            // Act
            bool contains = inventory.ContainsElement(element);
        
            // Assert
            Assert.IsFalse(contains);
        }
    
        [Test]
        public void IsFull_WhenCapacityReached_ShouldReturnTrue()
        {
            // Arrange
            var inventory = new Inventory(1);
            var element = NSubstitute.Substitute.For<IInventoryElement>();
        
            inventory.AddElement(element);
        
            // Act
            bool isFull = inventory.IsFull;
        
            // Assert
            Assert.IsTrue(isFull);
        }
    
        [Test]
        public void IsFull_WhenCapacityNotReached_ShouldReturnFalse()
        {
            // Arrange
            var inventory = new Inventory(2);
            var element = NSubstitute.Substitute.For<IInventoryElement>();
        
            inventory.AddElement(element);
        
            // Act
            bool isFull = inventory.IsFull;
        
            // Assert
            Assert.IsFalse(isFull);
        }
    
        [Test]
        public void ElementCount_WhenElementsAdded_ShouldReturnCorrectCount()
        {
            // Arrange
            var inventory = new Inventory();
            var element1 = NSubstitute.Substitute.For<IInventoryElement>();
            var element2 = NSubstitute.Substitute.For<IInventoryElement>();
        
            // Act
            inventory.AddElement(element1);
            inventory.AddElement(element2);
        
            // Assert
            Assert.AreEqual(2, inventory.ElementCount);
        }
    
        [Test]
        public void GetElements_ShouldReturnReadOnlyListOfElements()
        {
            // Arrange
            var inventory = new Inventory();
            var element1 = NSubstitute.Substitute.For<IInventoryElement>();
            var element2 = NSubstitute.Substitute.For<IInventoryElement>();
        
            inventory.AddElement(element1);
            inventory.AddElement(element2);
        
            // Act
            var elements = inventory.GetElements;
        
            // Assert
            Assert.AreEqual(2, elements.Count);
            Assert.IsTrue(elements.Contains(element1));
            Assert.IsTrue(elements.Contains(element2));
        }
    }
}