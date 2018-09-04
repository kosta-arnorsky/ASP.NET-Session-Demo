using System;

namespace FakeBackend
{
    public class Repository
    {
        private readonly object _options;

        public Repository(object options)
        {
            _options = options;
        }

        public Item GetItem(long itemId)
        {
            return new Item
            {
                Id = itemId,
                Property1 = itemId * 3,
                Property2 = "It's Property2 value of item " + itemId
            };
        }

        public Item[] GetItems()
        {
            var id = DateTime.Now.Ticks % 100;

            return new Item[]
            {
                GetItem(id),
                GetItem(id + 2),
                GetItem(id + 5)
            };
        }
    }
}
