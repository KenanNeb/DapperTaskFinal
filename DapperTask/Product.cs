namespace DapperTask
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public decimal Cost { get; set; }
        public override string ToString() => $"{Id}. {Name} {Country} {Cost}";
    }

}
