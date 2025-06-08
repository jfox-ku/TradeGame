using System.Collections;
using System.Collections.Generic;
using TradeGameNamespace.Inventory;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class InventoryTests
{
    [Test]
    public void Inventory_GivenCapacity_ShouldHaveCorrectCapacity()
    {
        // Arrange
        var elements = new List<IInventoryElement>();
        var capacity = 10;
        var inventory = new Inventory(elements, capacity);

        // Act
        int actualCapacity = inventory.Capacity;

        // Assert
        Assert.AreEqual(capacity, actualCapacity);
    }
}
