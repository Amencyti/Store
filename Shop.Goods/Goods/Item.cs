namespace Shop.Goods
{
    public abstract class Item
    {
        public int id { get; set; }
        public string article { get; set; }
        public string uid { get; set; }
        public string name { get; set; }
        public int unitOfMeasurementId { get; set; }
        public UnitOfMeasurement unitOfMeasurement { get; set; }
        public string shortDescription { get; set; }
        public string description { get; set; }
        public bool available { get; set; }
        public double cost { get; set; }
        public ItemType itemType { get; set; }
        public double selfCost { get; set; }
        public int count { get; set; }

        public override string ToString()
        {
            return this.name;
        }
    }

    public enum ItemType
    {
        Tech,
        Gold
    }
}









