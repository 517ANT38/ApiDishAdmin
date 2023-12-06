namespace ApiDishAdmin
{
    public class Dish 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public double Calorific { get; set; }
        public double Weight { get; set; }
        public string Category { get; set; }
        public string Catering { get; set; }
        public byte[] Img { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
