namespace FoodStoreeDB.AppDb
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public string Provider { get; set; }
        public string ProductType { get; set; }
    }
}
