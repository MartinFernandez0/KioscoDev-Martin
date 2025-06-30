namespace Backend.Example
{
    public class Example
    {
        public string Name { get; set; }
        public string Descriptionssss { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Example(string name, string description, int quantity, decimal price)
        {
            Name = name;
            Descriptionssss = description;
            Quantity = quantity;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - {Descriptionssss} - {Quantity} - {Price:C}";
            return $"{Name} - {Descriptionssss} - {Quantity} - {Price:C2}";
        }
    }
}
