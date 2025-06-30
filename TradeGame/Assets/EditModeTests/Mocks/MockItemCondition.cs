using TradeGameNamespace.Items.ItemConditions;

namespace EditModeTests.Mocks
{
    public class MockItemCondition : ItemCondition
    {
        public MockItemCondition(string name, float valuePercentDelta) : base(name, valuePercentDelta){
            
        }
    }
}