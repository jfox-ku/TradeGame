using TradeGameNamespace.Items.ItemCategories;

namespace EditModeTests.Mocks
{
    public class MockItemCategory : IItemCategory
    {
        public string Name { get; }
        public MockItemCategory(string name)
        {
            Name = name;
        }
    }
}