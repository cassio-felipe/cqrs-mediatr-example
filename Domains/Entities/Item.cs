using System;

namespace CQRSMediatrExample.Domains.Entities
{
    public class Item
    {
        public Item(string name, string code)
        {
            Id = Guid.NewGuid();
            ItemName = name;
            ItemCode = code;
        }

        public Guid Id { get; private set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
    }
}