namespace MobilunityTestTask.Server.Models
{
    public class CategoryNode
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<CategoryNode> Children { get; set; } = [];
    }
}
