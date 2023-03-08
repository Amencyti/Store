namespace Shop.Goods
{
    public class UnitOfMeasurement
    {
        public int id { get; set; }
        public string name { get; set; }

        public UnitOfMeasurement(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}