namespace todolistgql 
{
    public class ItemList
    {
        public ItemList()
        {
            ItemData = new HashSet<ItemData>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ItemData> ItemData { get; set; }
    }
}