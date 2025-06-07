namespace DefaultNamespace.Items.ItemCategories
{
    public abstract class ItemCategory : IItemCategory
    {
        public string Name { get; }
        
        protected ItemCategory(string name)
        {
            Name = name;
        }
    }
}