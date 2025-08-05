using EditModeTests.Mocks;
using NSubstitute;
using NUnit.Framework;
using TradeGameNamespace.Inventory;
using TradeGameNamespace.Items;
using TradeGameNamespace.Items.ItemCategories;
using TradeGameNamespace.Items.ItemConditions;
using TradeGameNamespace.Trader;
using TradeGameNamespace.ValueSystem;
using UnityEngine;

namespace EditModeTests
{
    public class TraderValueEvaluationTests
    {
        [Test]
        public void Evaluate_GivenNoPreferences_ReturnsOriginalValue()
        {
            // Arrange
            var valuable = Substitute.For<IValuable>();
            var traderData = Substitute.For<ITraderData>();
            valuable.Value.Returns(100f);
            
            var trader = new Trader(IInventory.NewEmpty, traderData);
            
            // Act
            var value = trader.Evaluate(valuable);

            // Assert
            Assert.AreEqual(100f, value);
        }

        [Test]
        public void Evaluate_GivenCategoryPreferences_ReturnsCorrectValue_For_PreferenceStrength_ItemValue(
            [Values(-2f, -1f, -0.5f, 0f, 0.5f, 1f, 2f)]float preferenceStrength,
            [Values(0f, 0.5f, 1f, 2f)]float itemValue) {
            //Arrange
            var itemDefinition = Substitute.For<IItemDefinition>();
            var itemCategory = new MockItemCategory("Mock");
            itemDefinition.BaseValue.Returns(itemValue);
            itemDefinition.Categories.Returns(new ItemCategory[] {itemCategory});
            var item = new Item(itemDefinition);
            
            var traderData = Substitute.For<ITraderData>();
            var traderPreferencesCollection = Substitute.For<ITraderPreferencesCollection>();
            var traderCategoryPreferences = new TraderPreferences<IItemCategory>();
            traderCategoryPreferences.SetPreferenceStrength(itemCategory, preferenceStrength);
            traderPreferencesCollection.GetPreferenceStrength(itemCategory).Returns(preferenceStrength);
            traderData.PreferencesCollection.Returns(traderPreferencesCollection);
            traderPreferencesCollection.CategoryPreferences.Returns(traderCategoryPreferences);
            
            var trader = new Trader(IInventory.NewEmpty, traderData);
            var expectedValue = itemValue + (itemValue * preferenceStrength);
            expectedValue = Mathf.Max(expectedValue, 0f);
            
            // Act
            var value = trader.Evaluate(item);
            Debug.Log($"Expected Value: " + expectedValue);
            Debug.Log($"Calculated Value: " + value);
            
            // Assert
            var areValuesClose = Mathf.Approximately(value, expectedValue);
            Assert.IsTrue(areValuesClose);
        }
        
        [Test]
        public void Evaluate_GivenConditionPreferences_ReturnsCorrectValue_For_PreferenceStrength_ConditionValueDelta_ItemValue(
            [Values(-2f, -1f, -0.5f, 0f, 0.5f, 1f, 2f)]float preferenceStrength,
            [Values(-2f, -1f, 0f, 1f, 2f)] float conditionValueDelta,
            [Values(0f, 0.5f, 1f, 2f)]float itemValue) {
            // Arrange
            var itemDefinition = Substitute.For<IItemDefinition>();
            itemDefinition.BaseValue.Returns(itemValue);
            var item = new Item(itemDefinition);
            
            var condition = new MockItemCondition("MockCondition", conditionValueDelta);
            item.AddCondition(condition);
            
            var traderData = Substitute.For<ITraderData>();
            var traderPreferencesCollection = Substitute.For<ITraderPreferencesCollection>();
            var traderConditionPreferences = new TraderPreferences<IItemCondition>();
            traderConditionPreferences.SetPreferenceStrength(condition, preferenceStrength);
            traderPreferencesCollection.GetPreferenceStrength(condition).Returns(preferenceStrength);
            traderData.PreferencesCollection.Returns(traderPreferencesCollection);
            traderPreferencesCollection.ConditionPreferences.Returns(traderConditionPreferences);
            
            var trader = new Trader(IInventory.NewEmpty, traderData);
            var expectedValue = itemValue + (itemValue * preferenceStrength * conditionValueDelta);
            expectedValue = Mathf.Max(expectedValue, 0f);
            
            // Act
            var value = trader.Evaluate(item);
            Debug.Log($"Expected Value: " + expectedValue);
            Debug.Log($"Calculated Value: " + value);
            
            // Assert
            Assert.AreEqual(expectedValue, value);
        }
        
        [Test]
        public void Evaluate_GivenMultipleCategoryAndConditionPreferences_ReturnsCorrectValue(
            [Values(0f,100f)]float itemBaseValue,
            [Values(-1f,0f,1f)]float category1PreferenceStrength,
            [Values(-1f,0f,1f)]float category2PreferenceStrength,
            [Values(-1f,0f,1f)]float condition1ValueDelta,
            [Values(-1f,0f,1f)]float condition1PreferenceStrength,
            [Values(-1f,0f,1f)]float condition2ValueDelta,
            [Values(-1f,0f,1f)]float condition2PreferenceStrength)
        {
            
            // Arrange
            var itemDefinition = Substitute.For<IItemDefinition>();
            itemDefinition.BaseValue.Returns(itemBaseValue);
            var itemCategory1 = new MockItemCategory("Category1");
            var itemCategory2 = new MockItemCategory("Category2");
            itemDefinition.Categories.Returns(new[] {itemCategory1, itemCategory2});
            var item = new Item(itemDefinition);
            
            var condition1 = new MockItemCondition("Condition1", condition1ValueDelta);
            var condition2 = new MockItemCondition("Condition2", condition2ValueDelta);
            item.AddCondition(condition1);
            item.AddCondition(condition2);
            
            var traderData = Substitute.For<ITraderData>();
            
            var traderCategoryPreferences = new TraderPreferences<IItemCategory>();
            traderCategoryPreferences.SetPreferenceStrength(itemCategory1, category1PreferenceStrength);
            traderCategoryPreferences.SetPreferenceStrength(itemCategory2, category2PreferenceStrength);
            
            var traderConditionPreferences = new TraderPreferences<IItemCondition>();
            traderConditionPreferences.SetPreferenceStrength(condition1, condition1PreferenceStrength);
            traderConditionPreferences.SetPreferenceStrength(condition2, condition2PreferenceStrength);
            
            var traderPreferencesCollection = new TraderPreferencesCollection(traderCategoryPreferences, traderConditionPreferences);
            
            traderData.PreferencesCollection.Returns(traderPreferencesCollection);
            
            var trader = new Trader(IInventory.NewEmpty, traderData);
            
            var expectedValue = itemBaseValue
                                + (itemBaseValue * category1PreferenceStrength) // Category 1 effect
                                + (itemBaseValue * category2PreferenceStrength) // Category 2 effect
                                + (itemBaseValue * condition1ValueDelta * condition1PreferenceStrength) // Condition 1 effect
                                + (itemBaseValue * condition2ValueDelta * condition2PreferenceStrength); // Condition 2 effect
            expectedValue = Mathf.Max(expectedValue, 0f);
            
            // Act
            var value = trader.Evaluate(item);
            Debug.Log($"Expected Value: " + expectedValue);
            Debug.Log($"Calculated Value: " + value);
            
            // Assert
            Assert.AreEqual(expectedValue, value);
        }
    }
}