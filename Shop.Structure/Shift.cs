namespace Shop.Structure
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public List<Employee> employees { get; set; }
        public int storeId { get; set; }
        public Store store { get; set; }
    }
}