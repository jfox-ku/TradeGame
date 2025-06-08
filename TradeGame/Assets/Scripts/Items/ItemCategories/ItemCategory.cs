namespace TradeGameNamespace.Items.ItemCategories
{
    public abstract class ItemCategory : IItemCategory
    {
        public string Name { get; }
        
        protected ItemCategory(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is IItemCategory otherCategory)
            {
                return Name == otherCategory.Name;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}