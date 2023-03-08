namespace Shop.Goods
{
    public class TechItem : Item
    {

        public TechModel model { get; set; }
        public int typeId { get; set; }
        public TechType type { get; set; }
        public int manufacturerId { get; set; }
        public Manufacturer manufacturer { get; set; }

        public TechItem()
        {

        }

    }
}