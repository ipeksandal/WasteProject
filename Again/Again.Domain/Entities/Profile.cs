namespace Again.Domain.Entities;

public class Profile
{
    public User Id { get; set; }
    public User UserName { get; set; }
    public User Email { get; set; }
    public string Bio { get; set; }
    public int PaperRecycled { get; set; }
    public int GlassRecycled { get; set; }
    public int PlasticRecycled { get; set; }
    public int MetalRecycled { get; set; }
}