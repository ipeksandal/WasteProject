namespace Again.Domain.Entities;

public class Profile
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
    public int PaperRecycled { get; set; }
    public int GlassRecycled { get; set; }
    public int PlasticRecycled { get; set; }
    public int MetalRecycled { get; set; }
}