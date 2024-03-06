namespace Api.Payloads
{
    public sealed record ProductDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}
