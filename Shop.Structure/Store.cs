namespace Shop.Structure
{
    public class Store
    {
        public int Id { get; set; }
        public string suffix { get; set; }
        public string name { get; set; }
        public Organization organization { get; set; }
        public Warehouse warehouse { get; set; }

    }
}