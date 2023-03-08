
namespace Shop.Goods
{
    public class Manufacturer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
        public Manufacturer() { }
        public Manufacturer(string name, string uid)
        {
            this.name = name;
            this.uid = uid;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}