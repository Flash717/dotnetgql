namespace todolistgql
{
    public class Query
    {
        public IQueryable<ItemData> GetItem([Service] ApiDbContext context)
        {
            return context.Item;
        }
    }
}