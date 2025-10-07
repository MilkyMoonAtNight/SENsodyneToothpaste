public class Module
{
    public int Id { get; set; }
    public string ModuleName { get; set; }
    public string ModuleCode { get; set; }
    public List<Topic> Topics { get; set; } = new();
}