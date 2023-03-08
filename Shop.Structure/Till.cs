namespace Shop.Structure
{
    public class Till
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int storeId { get; set; }
        public Store store { get; set; }
    }
}