public class TestClass
{
    public int ID { get; set; }
    // Other properties...
}

public class InMemoryRepository<T> where T : class
{
    private readonly Dictionary<object, T> _items;
    private readonly Func<T, object> _keySelector;

    public InMemoryRepository(Func<T, object> keySelector)
    {
        _keySelector = keySelector;
        _items = new Dictionary<object, T>();
    }

    public void Add(T item)
    {
        var key = _keySelector(item);
        _items.Add(key, item);
    }

    public T Find(object key)
    {
        if (_items.TryGetValue(key, out T item))
        {
            return item;
        }

        return null; // or throw an exception, depending on your needs
    }

    // Implement other methods (Update, Delete, etc.) as needed...
}
