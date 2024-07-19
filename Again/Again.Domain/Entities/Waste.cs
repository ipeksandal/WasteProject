namespace Again.Domain.Entities;

public class Waste
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string WasteType { get; set; }
    public string Description { get; set; }
}