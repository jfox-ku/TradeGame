using TradeGameNamespace.Items.ItemConditions;

namespace EditModeTests.Mocks
{
    public class MockItemConditionOther : ItemCondition
    {
        public MockItemConditionOther(string name, float valuePercentDelta) : base(name, valuePercentDelta){
            
        }
    }
}