namespace Shop.Goods
{
    public class TechModel
    {

        public int id { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
        public int manufacturerId { get; set; }
        public Manufacturer manufacturer { get; set; }

        public TechModel() { }
        public TechModel(string name, string uid, Manufacturer manufacturer)
        {
            this.name = name;
            this.uid = uid;
            this.manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return this.name;
        }

    }
}