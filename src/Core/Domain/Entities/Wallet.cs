namespace Domain.Entities
{
    public class Wallet:EntityBase
    {
        public string Name { get;set; }
        public decimal Saldo { get; set; }
        public bool Deleted { get; set; }

    }
}